using IniParser;
using IniParser.Model;
using Serilog;
using Serilog.Formatting.Json;
using System;
using System.IO;

namespace SiraIntegration.Helpers
{
    public static class LoggerSetup
    {
        public static void InitializeLogger()
        {
            string logFolder = INIHelper.LoadLogSettings().Folder;

            if (string.IsNullOrEmpty(logFolder))
                logFolder = @"C:\Roboost\SiraLogs";

            if (!Directory.Exists(logFolder))
            {
                Directory.CreateDirectory(logFolder);
            }

            var logFile = Path.Combine(logFolder, "Sira-.txt");

            Log.Logger = new LoggerConfiguration()
                .Enrich.WithProperty("Application", "SiraIntegration")
      .MinimumLevel.Information()
      .WriteTo.File(
        path: logFile,

      outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] [{Application}] {Message:lj}{NewLine}",
        rollingInterval: RollingInterval.Day,
        retainedFileCountLimit: 3
)


                .CreateLogger();

        }
    }
}
