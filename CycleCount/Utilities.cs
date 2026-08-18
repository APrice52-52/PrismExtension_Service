using CycleCount.Configuration;
using CycleCount;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CycleCount;


public enum EventType
{
    Information = 0,
    Error = 1,
    Warning = 2
}


public static class Utilities
{

    public static NumberFormatInfo Nfi = new NumberFormatInfo() { NumberDecimalSeparator = ".", CurrencyDecimalSeparator = "." };

    private static string _logFolder = "";

    private static System.Timers.Timer _errorExpiryTimer = new();
    private static System.Timers.Timer _clearLogTimer = new();


    static Utilities()
    {
        //var asasas = Assembly.GetEntryAssembly().GetManifestResourceNames();
        //LogEvent(EventType.Warning, string.Join("\r\n", asasas));

        try
        {
            _errorExpiryTimer.Interval = 180000; // 3min
            _errorExpiryTimer.AutoReset = true;
            _errorExpiryTimer.Elapsed += _errorExpiryTimer_Elapsed;
            _errorExpiryTimer.Start();

            ClearLog();
            _clearLogTimer.Interval = 60 * 60 * 24 * 1000; // daily
            _clearLogTimer.AutoReset = true;
            _clearLogTimer.Elapsed += _clearLogTimer_Elapsed;
            _clearLogTimer.Start();
        }
        catch (Exception ex)
        {
            LogEvent(ex);
#if (!DEBUG)
                throw;
#endif
        }
    }

    private static void _errorExpiryTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
    {
        try
        {
            var cutOff = DateTime.Now.AddMinutes(-90);
            foreach (var item in _errorList)
            {
                try
                {
                    if (item.Value < cutOff)
                        _ = _errorList.TryRemove(item);
                }
                catch { }
            }
        }
        catch { }
    }

    private static void _clearLogTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
    {
        ClearLog();
    }
    private static void ClearLog()
    {
        // Clear Log:
        try
        {
            var files = Directory.GetFiles(_logFolder, "*.csv", SearchOption.TopDirectoryOnly);
            var expDate = DateTime.Now.AddDays(CycleCountConfig.Load().LogExpiryDays * -1).Date;

            foreach (var file in files)
            {
                try
                {
                    var fi = new FileInfo(file);
                    if (fi.CreationTime < expDate)
                        File.Delete(file);
                }
                catch { }
            }
        }
        catch { }

        // Clear error cache:
        try
        {
            _errorList.Clear();
        }
        catch { }
    }

    private const string _eventSource = "PrismCycleCount";

    public static string? SetMaxLength(this string? x, int length = 0)
    {
        if (x == null)
            return null;
        if (length == 0) 
            return string.Empty;
        else if (x.Length < length) 
            return x;
        else 
            return x.Substring(0, length);
    }

    public static string? SetMaxLengthRev(this string x, int length = 0, bool trim = false)
    {
        if (x == null)
            return null;
        if (length == 0)
            return string.Empty;
        
        if (trim)
            x = x.Trim();
        
        if (x.Length < length)
            return x;
        else
            return x.Substring(x.Length - length, length);
    }


    private static readonly object _lckSetConfig = new object();
    internal static void SetConfig(CycleCountConfig config)
    {
        try {
            lock (_lckSetConfig) {
                _logFolder = config.LogFolder;
            }
        }
        catch (Exception ex) {
            LogEvent(ex);
        }
    }

    public static void LogEvent(string errorRef, Exception ex, int eventId = 1000)
    {
        string s = string.Format("{0}\r\n{1}\r\n{2}", errorRef, ex.Message, ex.StackTrace);
        if (ex.InnerException != null)
        {
            s = s + "\r\nInner Exception:" + ex.InnerException.Message + "\r\n" + ex.InnerException.StackTrace;
        }
        LogEventPrivate(EventType.Error, s, eventId, ex.Message);
    }

    public static void LogEvent(string errorRef, string message, EventType entryType, int eventId = 1000)
    {
        string s = string.Format("{0}:{1}", errorRef, message);
        LogEventPrivate(entryType, s, eventId, message);
    }

    public static void LogEvent(Exception ex, int eventId = 1000)
    {
        string s = string.Format("{0}\r\n{1}", ex.Message, ex.StackTrace);
        if (ex.InnerException != null)
        {
            s = s + "\r\nInner Exception:" + ex.InnerException.Message + "\r\n" + ex.InnerException.StackTrace;
        }
        LogEventPrivate(EventType.Error, s, eventId, ex.Message);
    }
    public static void LogWarning(Exception ex, int eventId = 1000)
    {
        string s = string.Format("{0}\r\n{1}", ex.Message, ex.StackTrace);
        if (ex.InnerException != null)
        {
            s = s + "\r\nInner Exception:" + ex.InnerException.Message + "\r\n" + ex.InnerException.StackTrace;
        }
        LogEventPrivate(EventType.Warning, s, eventId, ex.Message);
    }

    public static void LogDebug(string message, CycleCountConfig cfg, EventType eventType = EventType.Information)
    {
        //if (cfg.LogDebugMessages)
            LogEventPrivate(eventType, message, 1000, message);
    }
    public static void LogDebug(Exception ex, CycleCountConfig cfg, int eventId = 1000)
    {
        //if (cfg.LogDebugMessages)
        //{
            string s = string.Format("{0}\r\n{1}", ex.Message, ex.StackTrace);
            if (ex.InnerException != null)
            {
                s = s + "\r\nInner Exception:" + ex.InnerException.Message + "\r\n" + ex.InnerException.StackTrace;
            }
            LogEventPrivate(EventType.Error, s, eventId, ex.Message);
        //}
    }

    public static void LogError(Exception ex, int eventId = 1000)
    {
        string s = string.Format("{0}\r\n{1}", ex.Message, ex.StackTrace);
        if (ex.InnerException != null)
        {
            s = s + "\r\nInner Exception:" + ex.InnerException.Message + "\r\n" + ex.InnerException.StackTrace;
        }
        LogEventPrivate(EventType.Error, s, eventId, ex.Message);
    }
    public static void LogError(string messagePrefix, Exception ex, int eventId = 1000)
    {
        string s = string.Format("{0}{1}\r\n{2}", messagePrefix, ex.Message, ex.StackTrace);
        if (ex.InnerException != null)
        {
            s = s + "\r\nInner Exception:" + ex.InnerException.Message + "\r\n" + ex.InnerException.StackTrace;
        }
        LogEventPrivate(EventType.Error, s, eventId, ex.Message);
    }
    public static void LogWarning(string message, int eventId = 1000)
    {
        LogEventPrivate(EventType.Warning, message, eventId, message);
    }
    public static void LogError(string message, int eventId = 1000)
    {
        LogEventPrivate(EventType.Error, message, eventId, message);
    }
    public static void LogInformation(string message, int eventId = 1000)
    {
        LogEventPrivate(EventType.Information, message, eventId, message);
    }

    public static void LogEvent(EventType entryType, string message, int eventId = 1000)
    {
        if (message == null) message = "<None>";
        LogEventPrivate(entryType, message, eventId, message);
    }

    private static System.Collections.Concurrent.ConcurrentDictionary<string, DateTime> _errorList = new();
    private static void LogEventPrivate(EventType entryType, string message, int eventId, string? messageOnly)
    {

        LogToFile(entryType, message, eventId, messageOnly);
        LogToWindows(entryType, message, eventId, messageOnly);
    }

    private static DateTime _lastLogDate = DateTime.MinValue;
    private static string _lastLogFileName = "";

    private static void LogToFile(EventType entryType, string message, int eventId, string? messageOnly)
    {
        try
        {
            if (!string.IsNullOrWhiteSpace(messageOnly))
            {

                if (DateTime.Now.Date != _lastLogDate) {
                    _lastLogDate = DateTime.Now.Date;
                    _lastLogFileName = Path.Combine(
                                            _logFolder,
                                            string.Format(
                                                "Log_{0}.csv",
                                                DateTime.Now.ToString("yyyy-MM-dd")
                                                )
                                            );
                }

                if (!Directory.Exists(_logFolder))
                    Directory.CreateDirectory(_logFolder);

                File.AppendAllText(
                                _lastLogFileName, 
                                string.Format(
                                        "{0},{1}\r\n", 
                                        DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"), 
                                        messageOnly.Replace(",", ";").Replace("\r\n", " ")
                                        )
                                );
            }
        }
        catch (Exception ex)
        {
            LogToWindows(EventType.Error, ex.Message, 1001, messageOnly);
        }
    }

    private static void LogToWindows(EventType entryType, string message, int eventId, string? messageOnly)
    {
        try
        {

            try
            {
                if (_errorList.TryGetValue(messageOnly ?? message, out var expiry))
                {
                    try
                    {
                        if (expiry > DateTime.Now)
                            return;
                    }
                    catch { }
                }
            }
            catch { }

            try { _errorList[messageOnly ?? message] = DateTime.Now.AddHours(1); }
            catch { }


            try { if (!EventLog.SourceExists(_eventSource)) EventLog.CreateEventSource(_eventSource, "Application"); }
            catch { }
            try { if (!EventLog.SourceExists(_eventSource)) EventLog.CreateEventSource(_eventSource, "Application"); }
            catch { }
            EventLogEntryType type;
            switch (entryType)
            {
                case EventType.Information:
                    type = EventLogEntryType.Information;
                    break;
                case EventType.Error:
                    type = EventLogEntryType.Error;
                    break;
                default:
                    type = EventLogEntryType.Warning;
                    break;
            }

            EventLog.WriteEntry(
                        _eventSource, 
                        message.SetMaxLength(2000), 
                        type, 
                        eventId
                        );

        }
        catch (Exception ex)
        {
            try
            {
                if (!EventLog.SourceExists(_eventSource)) 
                    EventLog.CreateEventSource(_eventSource, "Application");

                EventLog.WriteEntry(
                            _eventSource, 
                            ex.Message + " : " + ex.StackTrace, 
                            EventLogEntryType.Error
                            );
            }
            catch { }
        }
    }


    public static void PreserveStackTrace(Exception exception)
    {
        try
        {
            MethodInfo? preserveStackTrace = typeof(Exception).GetMethod("InternalPreserveStackTrace", BindingFlags.Instance | BindingFlags.NonPublic);
            preserveStackTrace?.Invoke(exception, null);
        }
        catch { }
    }

    public static void ErrorLoggingExecutor(Action action, bool rethrow = false, string? sourceInfo = null, int eventId = 1000)
    {
        ErrorLoggingExecutor(() => { action(); return 0; }, rethrow, sourceInfo, eventId);
    }

    public static T? ErrorLoggingExecutor<T>(Func<T> action, bool rethrow = false, string? sourceInfo = null, int eventId = 1000)
    {

        try
        {
            return action();
        }
        catch (Exception ex)
        {
            LogEvent(ex);
            if (sourceInfo != null)
            {
                Utilities.LogEvent(EventType.Error, string.Format("Previous Error Source:\r\n{0}", sourceInfo), eventId);
            }
            if (rethrow)
            {
                PreserveStackTrace(ex);
                throw;
            }
        }

        return default(T);
    }

    public static bool TryParseBool(this string? value, out bool result, bool strict = false)
    {

        bool result2;
        if (string.IsNullOrWhiteSpace(value) || value.Length == 0)            {
            result = false;
            return true;
        }
        else if (bool.TryParse(value, out result2))
        {
            result = result2;
            return true;
        }
        else
        {
            decimal i;
            if (decimal.TryParse(value, out i))
            {
                if (i == 0)
                {
                    result = false;
                    return true;
                }
                else if (i == 1)
                {
                    result = true;
                    return true;
                }
                else if (!strict && i != 0)
                {
                    result = true;
                    return true;
                }
            }
        }

        result = false;
        return false;

    }


    public static string GetStringResource(string name)
    {
        using Stream? stream = Assembly.GetExecutingAssembly()!.GetManifestResourceStream(name);
        if (stream == null)
            return string.Empty;

        using StreamReader reader = new StreamReader(stream);
        
        string result = reader.ReadToEnd();
        return result;
    }

    public static DateTime? UnixTimeStampToDateTime(this long? unixTimeStamp)
    {
        if (!unixTimeStamp.HasValue)
            return null;
        var offset = DateTimeOffset.FromUnixTimeMilliseconds(unixTimeStamp.Value);
        return offset.LocalDateTime;
    }
}



