# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Build & Run

```bash
# Build entire solution
dotnet build

# Build a single project
dotnet build PrismExtensionServices/PrismExtensionServices.csproj
dotnet build PrismExtensionServices.Shared/PrismExtensionServices.Shared.csproj

# Run the host (development — reads config from ProgramData, listens on ServicePort)
cd PrismExtensionServices
dotnet run

# Publish for Windows Service deployment
dotnet publish PrismExtensionServices/PrismExtensionServices.csproj -c Release -r win-x64 --self-contained
```

## Service Installation

```cmd
sc create "PrismExtensionService" displayname="Prism Extension Service" binPath="<publish-path>\PrismExtensionServices.exe"
sc start PrismExtensionService
sc stop  PrismExtensionService
sc delete PrismExtensionService
```

## Architecture

Two-project solution:

**`PrismExtensionServices.Shared`** (`net10.0`) — shared contract library. Plugins and the host both reference this; neither may reference the other. Contains:
- `IPrismPlugin` — plugin entry point (`Id`: 20-char Base-36, `Name`, `ConfigureServices`)
- `IDbHelper`, `IPrismHelper`, `IPrismPluginHost` — host services available to plugins via DI

**`PrismExtensionServices`** (`net10.0-windows`) — ASP.NET Core 10 Web API host, runs as a Windows Service. Contains:
- `Plugins/PluginLoadContext` — one `AssemblyLoadContext` per plugin DLL; intentionally routes `PrismExtensionServices.Shared` to the **default** context so shared interface types are identical across host and plugins; resolves each plugin's private dependencies via `AssemblyDependencyResolver` reading that plugin's `.deps.json`
- `Plugins/PluginLoader` — scans `PluginsFolder` for **one subdirectory per plugin** at startup, loads every DLL in each subdirectory that contains a concrete `IPrismPlugin`
- `Services/DbHelper` — `IDbHelper` implementation; `GetConnection()` uses the read credentials (`DbReadUsername`/`DbReadPassword`), `GetManagementConnection()` uses the elevated/DDL credentials (`DbManagementUsername`/`DbManagementPassword`) — both password fields are DPAPI-decrypted transparently by the config class
- `Program.cs` — wires everything: clears default config sources, loads config, registers DI, loads plugins, calls `AddApplicationPart` per plugin assembly so their controllers are discovered by MVC

## Configuration

`PrismExtensionServicesConfig` lives in `PrismExtensionServices/Configuration/`, inherits `PpitConfig.ConfigBase` (host project only — plugins do not reference it).

Live config: `C:\ProgramData\Price Point IT\PrismExtensionServices\PrismExtensionServices.config.json`
Solution reference copy: `PrismExtensionServices.config.json` (always re-copy after updating the live file)
Sample/template: `PrismExtensionServices.config.json.sample`

Folder-path properties (instance properties inherited from `ConfigBase`, computed as `{CommonAppData}\Price Point IT\{ApplicationName}`): `AppDataFolder`, `LogFolder`.

Key instance fields:
| Field | Notes |
|---|---|
| `DbReadUsername` / `DbReadPassword` | Credentials used by `IDbHelper.GetConnection()` (normal read/write access). Password is `[JsonConverter(typeof(EncryptedStringConverter))]` — DPAPI-encrypted transparently on save/load |
| `DbManagementUsername` / `DbManagementPassword` | Credentials used by `IDbHelper.GetManagementConnection()` (elevated/DDL access). Password encrypted the same way |
| `ServicePort` | Kestrel listen port |
| `PluginsFolder` | Relative paths resolve from `AppContext.BaseDirectory`; defaults to `plugins/` |
| `Plugins` | `Dictionary<string, ExtensionConfig>` keyed by plugin's 20-char Base-36 `Id` |

Config is loaded via `PrismExtensionServicesConfig.Load()` in `Program.cs`. `Load`/`Save` are inherited from `PpitConfig.ConfigBase`.

## Plugin Development

A plugin is a class library that:
1. References **only** `PrismExtensionServices.Shared` (never the host project)
2. Implements `IPrismPlugin` (the host discovers it via reflection)
3. Declares its REST controllers normally — the host registers them via `AddApplicationPart`

Each plugin gets **its own subfolder** under `plugins/` next to the exe — the full `dotnet publish` output of the plugin project (main DLL + `.deps.json` + private dependency DLLs), e.g.:

```bash
dotnet publish MyPlugin/MyPlugin.csproj -c Release -o plugins/MyPlugin
```

Do **not** drop multiple plugins' publish output into the same flat folder — private dependency DLLs (e.g. different versions of the same NuGet package across plugins) would collide on disk. One subfolder per plugin keeps each plugin's dependencies isolated both on disk and at runtime (each subfolder gets its own `PluginLoadContext`).

The host injects `IDbHelper`, `IPrismHelper`, and `IPrismPluginHost` into plugin-registered services automatically because they are registered in the host's DI container before `plugin.ConfigureServices` is called.
