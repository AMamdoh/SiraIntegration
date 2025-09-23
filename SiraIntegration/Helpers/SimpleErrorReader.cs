using Microsoft.Extensions.Logging;
using SiraIntegration.Helpers.Settings;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace SiraIntegration.Helpers
{
    public class SimpleErrorReader
    {
        private readonly ILogger _logger;

        public SimpleErrorReader(ILogger logger = null)
        {
            _logger = logger;
        }

        public string GetLastError()
        {
            try
            {
                string logsFolder = GetLogsFolder();
                if (!Directory.Exists(logsFolder))
                    logsFolder = @"C:\Roboost\SiraLogs";

                string latestLogFile = GetLatestLogFile(logsFolder, "Sira-*.json");

                if (latestLogFile == null)
                    return "No recent log files found.";

                string lastError = FindLastErrorInFile(latestLogFile);
                return lastError ?? "No errors found in the latest log file.";
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error while reading log file");
                return "Failed to read log file.";
            }
        }

        private string GetLatestLogFile(string logsFolder, string searchPattern)
        {
            if (!Directory.Exists(logsFolder)) return null;

            return Directory.GetFiles(logsFolder, searchPattern)
                            .OrderByDescending(File.GetLastWriteTimeUtc)
                            .FirstOrDefault();
        }

        private string FindLastErrorInFile(string filePath)
        {
            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var reader = new StreamReader(fileStream))
                {
                    string lastErrorMessage = null;
                    string lastErrorDate = null;
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        line = line.Trim();
                        if (string.IsNullOrEmpty(line)) continue;

                        var errorInfo = TryGetJsonError(line) ?? TryGetTextError(line);
                        if (errorInfo != null)
                        {
                            lastErrorMessage = errorInfo.Message;
                            lastErrorDate = errorInfo.Date;
                        }
                    }

                    if (lastErrorMessage != null && lastErrorDate != null)
                        return $"[{lastErrorDate}] {lastErrorMessage}";

                    return lastErrorMessage;
                }
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error reading file: {FilePath}", filePath);
                return null;
            }
        }

        private class ErrorInfo { public string Message { get; set; } public string Date { get; set; } }

        private ErrorInfo TryGetJsonError(string jsonLine)
        {
            try
            {
                var doc = JsonDocument.Parse(jsonLine);
                var root = doc.RootElement;
                string level = GetJsonProperty(root, "Level") ?? GetJsonProperty(root, "@l") ?? GetJsonProperty(root, "level") ?? "";
                level = level.ToUpper();
                if (!IsErrorLevel(level)) return null;
                string message = GetJsonProperty(root, "RenderedMessage") ?? GetJsonProperty(root, "Message") ?? GetJsonProperty(root, "@m") ?? jsonLine;
                string timestamp = GetJsonProperty(root, "Timestamp") ?? GetJsonProperty(root, "@t") ?? GetJsonProperty(root, "timestamp") ?? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                return new ErrorInfo { Message = message, Date = timestamp };
            }
            catch { return null; }
        }

        private ErrorInfo TryGetTextError(string line)
        {
            var regex = new Regex(@"^\[(.+?\s+\d{2}:\d{2}:\d{2})\s+([A-Z]+)\]\s(.+)$");
            var match = regex.Match(line);
            if (!match.Success) return null;
            string timestamp = match.Groups[1].Value.Trim();
            string level = match.Groups[2].Value.ToUpper();
            string message = match.Groups[3].Value.Trim();
            if (!IsErrorLevel(level)) return null;
            return new ErrorInfo { Message = message, Date = timestamp };
        }

        private bool IsErrorLevel(string level) => level.Contains("ERR") || level.Contains("ERROR") || level.Contains("FTL") || level.Contains("FATAL");

        private string GetJsonProperty(JsonElement element, string propertyName) => element.TryGetProperty(propertyName, out var property) && property.ValueKind == JsonValueKind.String ? property.GetString() : null;

        private string GetLogsFolder()
        {
            var logSettings = INIHelper.LoadLogSettings();
            return logSettings?.Folder ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        }
    }
}

