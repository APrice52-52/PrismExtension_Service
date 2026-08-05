using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PrismExtensionServicesSetup_Installers
{
    internal static class Utilities
    {
        internal const string EventSource = "PrismExtensionServices";

        // Must match PrismExtensionServices.Configuration.PrismExtensionServicesConfig's
        // static folder paths and DPAPI entropy exactly, so the host can read what we write.
        public static string AppDataFolder =>
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                "Price Point IT\\PrismExtensionServices");

        public static string LogFolder => Path.Combine(AppDataFolder, "Logs");

        public static string ConfigFileName => Path.Combine(AppDataFolder, "PrismExtensionServices.json");

        private static readonly byte[] _entropy = { 7, 42, 183, 61, 200 };

        public static string EncryptDbPassword(string clearText)
        {
            if (string.IsNullOrEmpty(clearText))
                return null;

            return Convert.ToBase64String(
                ProtectedData.Protect(
                    Encoding.UTF8.GetBytes(clearText),
                    _entropy,
                    DataProtectionScope.LocalMachine));
        }

        public enum EventType
        {
            Information = 0,
            Error = 1,
            Warning = 2
        }

        public static void LogEvent(Exception ex, int eventId = 1000)
        {
            string s = ex.Message + "\r\n" + ex.StackTrace;
            if (ex.InnerException != null)
                s += "\r\nInner Exception:" + ex.InnerException.Message + "\r\n" + ex.InnerException.StackTrace;
            LogEvent(EventType.Error, s, eventId);
        }

        public static void LogEvent(EventType entryType, string message, int eventId = 1000)
        {
            try
            {
                if (!EventLog.SourceExists(EventSource))
                    EventLog.CreateEventSource(EventSource, "Application");

                EventLogEntryType type = entryType == EventType.Information
                    ? EventLogEntryType.Information
                    : entryType == EventType.Error
                        ? EventLogEntryType.Error
                        : EventLogEntryType.Warning;

                EventLog.WriteEntry(EventSource, message, type, eventId);
            }
            catch { }
        }
    }
}
