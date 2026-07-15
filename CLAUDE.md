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
- `PrismExtensionServicesConfig` — config POCO

**`PrismExtensionServices`** (`net10.0-windows`) — ASP.NET Core 10 Web API host, runs as a Windows Service. Contains:
- `Plugins/PluginLoadContext` — one `AssemblyLoadContext` per plugin DLL; intentionally routes `PrismExtensionServices.Shared` to the **default** context so shared interface types are identical across host and plugins
- `Plugins/PluginLoader` — scans `PluginsFolder` at startup, loads every DLL that contains a concrete `IPrismPlugin`
- `Services/DbHelper` — `IDbHelper` implementation; decrypts `DbPasswordJson` with DPAPI (`ProtectedData.Unprotect`, `LocalMachine` scope, same Base-64 format as other Prism apps)
- `Program.cs` — wires everything: clears default config sources, loads config, registers DI, loads plugins, calls `AddApplicationPart` per plugin assembly so their controllers are discovered by MVC

## Configuration

Live config: `C:\ProgramData\Price Point IT\PrismExtensionServices\PrismExtensionServices.json`
Solution reference copy: `PrismExtensionServices.json.sample`

Key fields:
| Field | Notes |
|---|---|
| `DbPasswordJson` | DPAPI-encrypted Base-64 (`LocalMachine` scope) — same pattern as `StyleViewConfig.DbPasswordJson` |
| `ServicePort` | Kestrel listen port (overrides `launchSettings.json` in production) |
| `PluginsFolder` | Relative paths resolve from `AppContext.BaseDirectory`; defaults to `plugins/` |
| `Plugins` | `Dictionary<string, JsonElement>` keyed by the plugin's 20-char Base-36 `Id` |

Default config sources are **cleared** in `Program.cs`; `appsettings.json` is not read at runtime. Override values with `PRISM_` prefixed environment variables.

## Plugin Development

A plugin is a class library that:
1. References **only** `PrismExtensionServices.Shared` (never the host project)
2. Implements `IPrismPlugin` (the host discovers it via reflection)
3. Declares its REST controllers normally — the host registers them via `AddApplicationPart`

Plugin DLLs (and their private dependencies) are dropped into the `plugins/` subfolder next to the exe. The host injects `IDbHelper`, `IPrismHelper`, and `IPrismPluginHost` into plugin-registered services automatically because they are registered in the host's DI container before `plugin.ConfigureServices` is called.
