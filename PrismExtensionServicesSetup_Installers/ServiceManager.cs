using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace PrismExtensionServicesSetup_Installers
{
    internal static class ServiceManager
    {
        internal const string ServiceName = "PrismExtensionService";
        internal const string DisplayName = "Prism Extension Service";

        public static void CreateService(string exePath)
        {
            RunSc(string.Format(
                "create \"{0}\" binPath= \"{1}\" start= auto DisplayName= \"{2}\"",
                ServiceName, exePath, DisplayName));

            RunSc(string.Format(
                "description \"{0}\" \"Hosts PrismExtensionServices plugins for Retail Pro Prism.\"",
                ServiceName));
        }

        public static void StartService()
        {
            using (var sc = new ServiceController(ServiceName))
            {
                if (sc.Status != ServiceControllerStatus.Running)
                {
                    sc.Start();
                    sc.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30));
                }
            }
        }

        public static void StopService()
        {
            try
            {
                using (var sc = new ServiceController(ServiceName))
                {
                    if (sc.Status != ServiceControllerStatus.Stopped)
                    {
                        sc.Stop();
                        sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(30));
                    }
                }
            }
            catch (InvalidOperationException)
            {
                // Service not installed - nothing to stop.
            }
        }

        public static void DeleteService()
        {
            RunSc(string.Format("delete \"{0}\"", ServiceName));
        }

        public static bool ServiceExists()
        {
            foreach (var sc in ServiceController.GetServices())
            {
                if (string.Equals(sc.ServiceName, ServiceName, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        private static void RunSc(string arguments)
        {
            string scPath = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.System),
                "sc.exe");

            var psi = new ProcessStartInfo(scPath, arguments)
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            using (var process = Process.Start(psi))
            {
                process.WaitForExit();
                if (process.ExitCode != 0)
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    throw new InvalidOperationException(string.Format(
                        "sc.exe {0} failed with exit code {1}. {2} {3}",
                        arguments, process.ExitCode, output, error));
                }
            }
        }
    }
}
