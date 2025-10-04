using System;
using System.Drawing;

namespace SiraIntegration.Helpers
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    public static class ToolStatusHelper
    {

        public static (string Text, Color Color) GetStatus()
        {
            try
            {
                var logSettings = INIHelper.LoadLogSettings();
                string logFolder = logSettings.Folder;

                if (string.IsNullOrEmpty(logFolder))
                {
                    logFolder = @"C:\Roboost\SiraLogs";
                }

                string logFilePath = Path.Combine(logFolder, $"Sira-{DateTime.Now:yyyyMMdd}.txt");

                if (!File.Exists(logFilePath))
                {
                    return ("file not found", Color.Green);
                }

        
                string lastLine = ReadLastLineSafely(logFilePath);

                if (lastLine != null && (lastLine.Contains("\"ERR\"") || lastLine.Contains("\"ERROR\"")))
                {
                    return ("Not Working", Color.Red);
                }
                else
                {
                    return ("Working", Color.Green);
                }
            }
            catch (Exception)
            {
                return ("Error Reading Log", Color.Orange);
            }
        }

    
        private static string ReadLastLineSafely(string path)
        {
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var sr = new StreamReader(fs))
                {
                    string line = null;
                    string tempLine;
                    while ((tempLine = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(tempLine))
                        {
                            line = tempLine;
                        }
                    }
                    return line;
                }
            }
            catch (IOException)
            {
                return null;
            }
        }
    }

}