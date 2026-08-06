# PrismExtensionServices

A pluggable ASP.NET Core Web API host that runs as a Windows Service and exposes
REST endpoints for extending [Retail Pro 9 Prism](https://www.retailpro.com/). Rather
than baking every custom integration into one monolithic app, functionality is split
into independently built and deployed **plugins** that the host discovers and loads
at startup.

The host is normally deployed behind Apache (or another reverse proxy) alongside the
Prism web client, so that plugin endpoints are reachable under a single path prefix
(e.g. `/ppExtApi`) on the same server as Prism itself.

## Why plugins?

- Each integration (custom pricing rules, order cancellation fees, loyalty tweaks,
  etc.) can be developed, versioned, and deployed independently of the host and of
  every other plugin.
- Plugins can bring their own NuGet dependencies without any risk of colliding with
  another plugin's dependencies — each plugin gets its own isolated load context.
- The host provides a small set of common services (database access, configuration,
  logging) so plugins don't need to reimplement plumbing.

## Solution layout

```
PrismExtensionServices.Shared/   Contract library (net10.0) — referenced by the host
                                  AND every plugin. Plugins reference ONLY this project,
                                  never the host.
PrismExtensionServices/          The host (net10.0-windows, ASP.NET Core Web API,
                                  runs as a Windows Service).
<YourPlugin>/                    One project per plugin, each producing its own
                                  publish output folder under the host's plugins/
                                  directory.
```

`PrismExtensionServices.Shared` is also published as a NuGet package
(`PricePointIT.PrismExtensionServices.Shared`) so plugin projects can be developed in
their own repositories without a source/project reference to this solution.

## How the host works

1. **Configuration** is loaded first (`PrismExtensionServicesConfig`, backed by
   `PpitConfig.ConfigBase`), giving the host its DB connection info, Kestrel port, and
   the `PluginsFolder` path.
2. **Plugins are loaded** by scanning `PluginsFolder` for subdirectories — one
   subdirectory per plugin. Every DLL in a plugin's subdirectory is scanned for a
   concrete `IPrismPlugin` implementation.
   - Each plugin subdirectory gets its own `AssemblyLoadContext`, with private
     dependencies resolved via that plugin's own `.deps.json`. This means two plugins
     can depend on different versions of the same NuGet package without conflict.
   - `PrismExtensionServices.Shared` is always resolved from the host's default load
     context, so interface types (`IPrismPlugin`, `IDbHelper`, etc.) are the exact same
     `Type` on both sides — this is what makes dependency injection across the
     load-context boundary work.
3. **Core services are registered in DI** (see below) *before* any plugin code runs.
4. **Each plugin's `ConfigureServices` is called**, letting it register its own
   services (hosted services, business logic, etc.) into the same DI container the
   host uses. Because the core services were already registered in the previous step,
   plugins can constructor-inject them freely.
5. **Each plugin's assembly is added as an MVC "Application Part"**
   (`AddApplicationPart`), so any `[ApiController]` classes the plugin declares are
   automatically discovered and routed by ASP.NET Core — no manual route
   registration needed.
6. The web host starts, `UsePathBase("/ppExtApi")` strips the reverse-proxy prefix,
   and all plugin controllers become reachable as normal REST endpoints.

## Services available to plugins

The host registers the following as singletons in DI **before** plugins are
configured, so any plugin service or controller can take them as constructor
parameters:

| Interface | Purpose |
|---|---|
| `IDbHelper` | `GetConnection()` returns a MySQL connection using read-level credentials; `GetManagementConnection()` returns one using elevated/DDL credentials. Plugins should never hold their own connection strings. |
| `IPrismHelper` | Reserved for shared Prism-specific helper logic. |
| `IPrismPluginHost` | `Version` (host API version) and `GetConfiguration<T>(pluginId)`, which deserializes the plugin's own configuration block (see below) into a strongly-typed object. |

In addition, standard ASP.NET Core services (`ILogger<T>` / `ILoggerFactory`,
`IHttpClientFactory` if registered, etc.) are available like in any other ASP.NET Core
app.

Plugins are free to register their own additional services (including
`IHostedService` background workers) inside `ConfigureServices` — those are private to
the plugin and not exposed to anyone else.

## Creating a plugin

A plugin is an ordinary .NET class library that:

1. Targets a framework compatible with the host (currently `net10.0`) and references
   **only** `PrismExtensionServices.Shared` — never the host project. This keeps
   plugins decoupled and prevents circular/duplicate type issues across load contexts.
2. Implements `IPrismPlugin`:

   ```csharp
   public interface IPrismPlugin
   {
       // 20-character Base-36 unique identifier for this plugin.
       string Id { get; }

       string Name { get; }

       void ConfigureServices(IServiceCollection services);
   }
   ```

   Example:

   ```csharp
   public class MyPlugin : IPrismPlugin
   {
       public string Id => "AB12CD34EF56GH78IJ90"; // 20-char Base-36, must be unique
       public string Name => "My Plugin";

       public void ConfigureServices(IServiceCollection services)
       {
           // Register any plugin-private services here, e.g.:
           services.AddHostedService<MyPluginStartup>();
       }
   }
   ```

3. Declares controllers normally — no special base class or attribute beyond the
   usual ASP.NET Core conventions:

   ```csharp
   [ApiController]
   [Route("[controller]")]
   public class MyPluginController : ControllerBase
   {
       private readonly IDbHelper _db;
       private readonly ILogger _logger;

       public MyPluginController(IDbHelper db, ILoggerFactory loggerFactory)
       {
           _db = db;
           _logger = loggerFactory.CreateLogger("MyPlugin");
       }

       [HttpGet("{id:long}")]
       public async Task<IActionResult> Get(long id)
       {
           using var conn = _db.GetConnection();
           await conn.OpenAsync();
           // ...
           return Ok(/* ... */);
       }
   }
   ```

   Because the plugin's assembly is registered as an MVC Application Part, this
   controller is automatically exposed at `/MyPlugin/...` once the plugin is deployed
   — the same as if it had been written directly in the host.

4. (Optional) Reads its own configuration. Each plugin's config is stored, per
   plugin `Id`, as a Base64-encoded JSON blob in the host's config file (see below).
   To consume it, define a plain class matching the JSON shape and call:

   ```csharp
   var myConfig = pluginHost.GetConfiguration<MyPluginConfig>(pluginId);
   ```

   If the plugin's config class inherits `PpitConfig.ConfigBase`, it can also be
   edited later through the shared PPIT configuration tooling.

5. (Optional) Opts into its own log file by exposing a `LogFileName` string property
   on its configuration object. The host inspects each plugin's config for this
   property at startup and, if present, routes all log events from that plugin's
   assembly into `{LogFileName}-<date>.log` instead of the shared host log. No
   `IPrismPlugin`/`IPrismPluginHost` changes are needed to use this — it's driven
   purely by the presence of that property in the plugin's config JSON.

## Deploying a plugin

Each plugin gets **its own subfolder** under the host's `plugins/` directory,
containing the full `dotnet publish` output of the plugin project (main DLL,
`.deps.json`, and any private dependency DLLs):

```bash
dotnet publish MyPlugin/MyPlugin.csproj -c Release -o <host>/plugins/MyPlugin
```

Do **not** drop multiple plugins' publish output into the same flat folder — private
dependency DLLs (e.g. different versions of the same NuGet package used by different
plugins) would collide on disk. One subfolder per plugin keeps every plugin's
dependencies isolated both on disk and at runtime, since each subfolder becomes its
own `AssemblyLoadContext`.

## Registering a plugin

Once a plugin's files are deployed under `plugins/<PluginName>/`, it still needs an
entry in the host's config file so it can be enabled and given its own configuration
block:

```json
{
  "Plugins": {
    "AB12CD34EF56GH78IJ90": {
      "Id": "AB12CD34EF56GH78IJ90",
      "Enabled": true,
      "ConfigurationData": "eyJTb21lU2V0dGluZyI6IDQyfQ=="
    }
  }
}
```

- The key is the plugin's `Id` (also the value of `Id` inside the entry).
- `ConfigurationData` is a Base64-encoded JSON object — whatever shape the plugin's
  own config class expects. An empty object is `eyJ9` — but `e30=` (`{}`) is also
  common if the plugin defines no settings yet.
- The host does not require the plugin's DLL and its config entry to be added at the
  same time, but a plugin with no config entry simply gets `null` back from
  `GetConfiguration<T>`.

Restart the Windows Service after adding new plugin files or config so the host
rescans the plugins folder.

## Build & run

```bash
# Build entire solution
dotnet build

# Run the host (development — reads config from ProgramData, listens on ServicePort)
cd PrismExtensionServices
dotnet run

# Publish the host for Windows Service deployment
dotnet publish PrismExtensionServices/PrismExtensionServices.csproj -c Release -r win-x64 --self-contained
```

## Service installation

```cmd
sc create "PrismExtensionService" displayname="Prism Extension Service" binPath="<publish-path>\PrismExtensionServices.exe"
sc start PrismExtensionService
sc stop  PrismExtensionService
sc delete PrismExtensionService
```

## Configuration

Live config: `C:\ProgramData\Price Point IT\PrismExtensionServices\PrismExtensionServices.config.json`

| Field | Purpose |
|---|---|
| `DbServer`, `DbPort` | MySQL/MariaDB server used by `IDbHelper`. |
| `DbReadUsername` / `DbReadPassword` | Credentials for `IDbHelper.GetConnection()` (normal read/write access). Password is encrypted at rest. |
| `DbManagementUsername` / `DbManagementPassword` | Credentials for `IDbHelper.GetManagementConnection()` (elevated/DDL access). Password is encrypted at rest. |
| `ServicePort` | Port Kestrel listens on. |
| `PluginsFolder` | Folder scanned for plugin subdirectories at startup; relative paths resolve against the exe's directory. |
| `Plugins` | Per-plugin `{ Id, Enabled, ConfigurationData }` entries, keyed by plugin `Id`. |

See `PrismExtensionServices.config.json.sample` for a full example, including sample
plugin entries.

## Reverse proxy

The host is designed to sit behind a reverse proxy (see
`prism-extension-services.conf` for a ready-to-use Apache config) that forwards
requests under a shared path prefix (e.g. `/ppExtApi`) to Kestrel, and forwards
`X-Forwarded-For` / `X-Forwarded-Proto` so ASP.NET Core sees the true client scheme
and address.

## Example plugin walkthrough

A typical plugin (illustrative only — not part of this repo):

- Implements `IPrismPlugin`, registering an `IHostedService` in `ConfigureServices`
  that runs once at startup to ensure a custom database table exists and is seeded.
- Exposes a controller with CRUD endpoints for editing per-record settings (e.g. a
  discount matrix keyed by two dimensions), plus a read-only endpoint the POS UI
  calls at checkout time to resolve a value for a given customer/item pair — always
  returning a `200 OK` with a safe default and an `Error` field on failure, rather
  than surfacing HTTP error codes to the POS.
- Uses `IDbHelper.GetConnection()` for all queries, with fully-qualified table names,
  and logs failures via the injected `ILogger` without throwing back to the caller.

This shape — one `IHostedService` for one-time setup plus one controller for CRUD and
a POS-facing read endpoint — is a common and recommended pattern for new plugins.
