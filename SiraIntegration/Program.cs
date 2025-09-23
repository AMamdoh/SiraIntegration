using IniParser;
using IniParser.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using SiraIntegration.Entities.Logger;
using SiraIntegration.Helpers;
using SiraIntegration.Services;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SiraIntegration
{
    internal static class Program
    {
        private static Microsoft.Extensions.Logging.ILogger _logger;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dbSettings = Helpers.INIHelper.LoadDatabaseSettings();
            Helpers.DapperHelper.SetConnection(
                dbSettings.ServerIP,
                dbSettings.DatabaseName,
                dbSettings.UserName,
                dbSettings.Password
            );

            //  Serilog settings
            LoggerSetup.InitializeLogger();

            var services = new ServiceCollection();

            services.AddLogging(builder =>
            {
                builder.AddConsole();
                builder.AddSerilog();
                builder.SetMinimumLevel(LogLevel.Information);
            });
            services.AddSingleton(new BindingList<LogEntry>());

            services.AddSingleton<UiLogger>();

            services.AddTransient<FrmMain>();
            services.AddTransient<OrderLogService>();


            using (var serviceProvider = services.BuildServiceProvider())
            {
                var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();
                _logger = loggerFactory.CreateLogger("Program");
                Application.ThreadException += UIThreadException;
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                var form = serviceProvider.GetRequiredService<FrmMain>();
                Application.Run(form);
            }
        }

        private static void CurrentDomain_UnhandledException(Object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                _logger?.LogError(ex, "Unhandled domain exception");
            }
            catch (Exception)
            {
                try
                {
                }
                finally
                {
                }
            }
        }

        private static void UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            try
            {
                Exception ex = (Exception)t.Exception;
                _logger?.LogError($"Exception: {ex.ToString()}");
            }
            catch
            {
                try
                {
                }
                finally
                {
                }
            }
        }
    }
}
