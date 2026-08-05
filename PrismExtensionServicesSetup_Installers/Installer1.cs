using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace PrismExtensionServicesSetup_Installers
{
    [RunInstaller(true)]
    public partial class Installer1 : Installer
    {
        public Installer1()
        {
            InitializeComponent();
            AfterInstall += Installer1_AfterInstall;
        }

        public override void Install(IDictionary stateSaver)
        {
            OnBeforeInstall();
            base.Install(stateSaver);
        }

        private void OnBeforeInstall()
        {
            string info = GetDotnetInfo();

            if (info.IndexOf("Microsoft.NETCore.App 10", StringComparison.OrdinalIgnoreCase) < 0 ||
                info.IndexOf("Microsoft.AspNetCore.App 10", StringComparison.OrdinalIgnoreCase) < 0)
            {
                throw new InstallException(
                    ".NET 10 Runtime and ASP.NET Core 10 Runtime are required but were not found. " +
                    "Install the .NET 10 Hosting Bundle before continuing.");
            }
        }

        private static string GetDotnetInfo()
        {
            try
            {
                var psi = new ProcessStartInfo("dotnet", "--info")
                {
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                };

                using (var process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    return output;
                }
            }
            catch (Exception ex)
            {
                Utilities.LogEvent(ex, 1001);
                return string.Empty;
            }
        }

        private void Installer1_AfterInstall(object sender, InstallEventArgs e)
        {
            try
            {
                string installFolder = Context.Parameters["targetdir"];
                if (string.IsNullOrEmpty(installFolder))
                    installFolder = AppDomain.CurrentDomain.BaseDirectory;

                string exePath = Path.Combine(installFolder, "PrismExtensionServices.exe");

                Directory.CreateDirectory(Path.Combine(installFolder, "plugins"));
                Directory.CreateDirectory(Utilities.AppDataFolder);
                Directory.CreateDirectory(Utilities.LogFolder);

                if (!File.Exists(Utilities.ConfigFileName))
                {
                    WriteConfig();
                }
                else
                {
                    Utilities.LogEvent(Utilities.EventType.Information,
                        "Existing configuration found - leaving it unchanged.", 1002);
                }

                ServiceManager.CreateService(exePath);
                ServiceManager.StartService();

                Utilities.LogEvent(Utilities.EventType.Information,
                    "PrismExtensionServices installed and service started successfully.", 1000);
            }
            catch (Exception ex)
            {
                Utilities.LogEvent(ex, 1003);
                throw;
            }
        }

        private void WriteConfig()
        {
            string dbServer = Context.Parameters["DBSERVER"];
            string dbPort = Context.Parameters["DBPORT"];
            string dbUsername = Context.Parameters["DBUSERNAME"];
            string dbPassword = Context.Parameters["DBPASSWORD"];

            if (string.IsNullOrEmpty(dbServer)) dbServer = "localhost";
            if (string.IsNullOrEmpty(dbPort)) dbPort = "3306";
            if (string.IsNullOrEmpty(dbUsername)) dbUsername = "root";

            string dbPasswordEncrypted = Utilities.EncryptDbPassword(dbPassword) ?? string.Empty;

            var sb = new StringBuilder();
            sb.Append("{\r\n");
            sb.Append("  \"DbServer\": \"").Append(JsonEscape(dbServer)).Append("\",\r\n");
            sb.Append("  \"DbPort\": ").Append(dbPort).Append(",\r\n");
            sb.Append("  \"DbUsername\": \"").Append(JsonEscape(dbUsername)).Append("\",\r\n");
            sb.Append("  \"DbPassword\": \"").Append(JsonEscape(dbPasswordEncrypted)).Append("\",\r\n");
            sb.Append("  \"ServicePort\": 5200,\r\n");
            sb.Append("  \"LogExpiryDays\": 30,\r\n");
            sb.Append("  \"LogDebugMessages\": false,\r\n");
            sb.Append("  \"PluginsFolder\": \"plugins\",\r\n");
            sb.Append("  \"Plugins\": {}\r\n");
            sb.Append("}\r\n");

            File.WriteAllText(Utilities.ConfigFileName, sb.ToString(), Encoding.UTF8);
        }

        private static string JsonEscape(string s)
        {
            return (s ?? string.Empty).Replace("\\", "\\\\").Replace("\"", "\\\"");
        }

        public override void Uninstall(IDictionary savedState)
        {
            try
            {
                ServiceManager.StopService();
                if (ServiceManager.ServiceExists())
                    ServiceManager.DeleteService();
            }
            catch (Exception ex)
            {
                Utilities.LogEvent(ex, 1004);
            }

            base.Uninstall(savedState);
        }
    }
}
