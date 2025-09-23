using IniParser;
using IniParser.Model;
using SiraIntegration.Helpers.Settings;
using SiraIntegration.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiraIntegration.Entities.Settings;

namespace SiraIntegration.Helpers
{
    public class INIHelper
    {
        private static readonly FileIniDataParser parser = new FileIniDataParser();

        // ===== Da
        // ase Settings Methods =====
        public static void SaveDatabaseSettings(DatabaseSettings settings)
        {
            EnsureConfigFileExists();

            var data = parser.ReadFile(Constants.CONFIG_FILE);

            data["Database"]["ServerIP"] = settings.ServerIP;
            data["Database"]["DatabaseName"] = settings.DatabaseName;
            data["Database"]["UserName"] = settings.UserName;
            data["Database"]["Password"] = settings.Password;
            data["Database"]["NewOrdersView"] = settings.NewOrdersView;
            data["Database"]["ReviewOrdersView"] = settings.ReviewsViewName;
            data["Database"]["SiraOrderTable"] = settings.SiraOrderTable;
            data["Database"]["RemoveOldOrdersInterval"] = settings.RemoveOldOrdersInterval.ToString();
            data["Database"]["RemoveOldOrdersUnit"] = settings.RemoveOldOrdersUnit;

            parser.WriteFile(Constants.CONFIG_FILE, data);
        }

        public static DatabaseSettings LoadDatabaseSettings()
        {
            EnsureConfigFileExists();

            var data = parser.ReadFile(Constants.CONFIG_FILE);

            return new DatabaseSettings
            {
                ServerIP = data["Database"]["ServerIP"],
                DatabaseName = data["Database"]["DatabaseName"],
                UserName = data["Database"]["UserName"],
                Password = data["Database"]["Password"],
                NewOrdersView = data["Database"]["NewOrdersView"],
                ReviewsViewName = data["Database"]["ReviewOrdersView"],
                SiraOrderTable = data["Database"]["SiraOrderTable"],
                RemoveOldOrdersInterval = decimal.TryParse(data["Database"]["RemoveOldOrdersInterval"], out var interval) ? interval : 0,
                RemoveOldOrdersUnit = data["Database"]["RemoveOldOrdersUnit"]
            };
        }

        public static void SaveStores(AllowStores  allowStores)
        {
            EnsureConfigFileExists();
            var data = parser.ReadFile(Constants.CONFIG_FILE);
            data["Stores"]["StoreCodes"] = string.Join(",", allowStores.StoreCodes);
            parser.WriteFile(Constants.CONFIG_FILE, data);

        }
        public static AllowStores LoadStores()
        {
            EnsureConfigFileExists();

            var data = parser.ReadFile(Constants.CONFIG_FILE);
            var raw = data["Stores"].ContainsKey("StoreCodes") ? data["Stores"]["StoreCodes"] : "";

            return new AllowStores
            {
                StoreCodes = raw.Split(new[] { ',' },
                StringSplitOptions.RemoveEmptyEntries).ToList()
            };
        }



        // ===== API Settings Methods =====
        public static void SaveAPISettings(ApiSettings settings)
        {
            EnsureConfigFileExists();

            var data = parser.ReadFile(Constants.CONFIG_FILE);
            data["API"]["URL"] = settings.Url;
            data["API"]["Token"] = settings.Token;

            parser.WriteFile(Constants.CONFIG_FILE, data);
        }

        public static ApiSettings LoadAPISettings()
        {
           EnsureConfigFileExists();

            var data = parser.ReadFile(Constants.CONFIG_FILE);

            return new ApiSettings
            {
                Url = data["API"]["URL"],
                Token = data["API"]["Token"]
            };
        }

        // ===== Timer Settings Methods =====
        public static void SaveTimerSettings(DispatchOrderSettings settings)
        {
            EnsureConfigFileExists();

            var data = parser.ReadFile(Constants.CONFIG_FILE);

            data["Timers"]["PostOrderInterval"] = settings.PostOrderInterval.ToString();
            data["Timers"]["PostOrderUnit"] = settings.PostOrderUnit;
            data["Timers"]["ReviewOrderInterval"] = settings.ReviewOrderInterval.ToString();
            data["Timers"]["ReviewOrderUnit"] = settings.ReviewOrderUnit;
            data["Timers"]["OrdersCount"] = settings.OrdersCount.ToString();
            data["Timers"]["ReviewsCount"] = settings.ReviewsCount.ToString();

            parser.WriteFile(Constants.CONFIG_FILE, data);
        }

        public static DispatchOrderSettings LoadTimerSettings()
        {
            EnsureConfigFileExists();

            var data = parser.ReadFile(Constants.CONFIG_FILE);

            return new DispatchOrderSettings
            {
                PostOrderInterval = int.TryParse(data["Timers"]["PostOrderInterval"], out int postInt) ? postInt : 1,
                PostOrderUnit = data["Timers"]["PostOrderUnit"],
              ReviewOrderInterval = int.TryParse(data["Timers"]["ReviewOrderInterval"], out int updateInt) ? updateInt : 1,
                ReviewOrderUnit = data["Timers"]["ReviewOrderUnit"],
                OrdersCount = int.TryParse(data["Timers"]["OrdersCount"], out int count) ? count : 1,
                ReviewsCount = int.TryParse(data["Timers"]["ReviewsCount"], out int Reviewcount) ? count : 1

            };
        }

        // ===== Log Settings Methods =====
        public static void SaveLogSettings(LogSettings settings)
        {
            EnsureConfigFileExists();

            IniData data = parser.ReadFile(Constants.CONFIG_FILE);

            data["Log"]["Folder"] = settings.Folder;
            data["Log"]["ClearLogInterval"] = settings.ClearLogInterval.ToString();
            data["Log"]["ClearLogUnit"] = settings.ClearLogUnit;

            parser.WriteFile(Constants.CONFIG_FILE, data);
        }

        public static LogSettings LoadLogSettings()
        {
            EnsureConfigFileExists();

            var data = parser.ReadFile(Constants.CONFIG_FILE);

            string folder = data["Log"].ContainsKey("Folder") ? data["Log"]["Folder"] : "";
            string clearLogIntervalStr = data["Log"].ContainsKey("ClearLogInterval") ? data["Log"]["ClearLogInterval"] : "1";
            string clearLogUnit = data["Log"].ContainsKey("ClearLogUnit") ? data["Log"]["ClearLogUnit"] : "Seconds";

            int.TryParse(clearLogIntervalStr, out int clearLogInterval);

            return new LogSettings
            {
                Folder = folder,
                ClearLogInterval = clearLogInterval,
                ClearLogUnit = clearLogUnit
            };
        }

        // ===== Helpers =====
        public static void EnsureConfigFileExists()
        {
            if (!File.Exists(Constants.CONFIG_FILE))
            {
                string directory = Path.GetDirectoryName(Constants.CONFIG_FILE);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var data = new IniData();
                parser.WriteFile(Constants.CONFIG_FILE, data);
            }
        }

        private static string GetValue(string section, string key, string defaultValue = "")
        {
            try
            {
                var data = parser.ReadFile(Constants.CONFIG_FILE);
                return data[section][key] ?? defaultValue;
            }
            catch
            {
                return defaultValue;
            }
        }

        public static int GetOrdersCount()
        {
            return int.Parse(GetValue(section: "Timers", "OrdersCount", "10"));
        }

        public static string GetAPI()
        {
            return GetValue("API", "URL", "");
        }

        // ===== Restriction Setting Methods =====
        public static void SaveRestrictionSettings(decimal maxHours)
        {
            EnsureConfigFileExists();
            var data = parser.ReadFile(Constants.CONFIG_FILE);
            data["Restrictions"]["MaxOrderAgeHours"] = maxHours.ToString();
            parser.WriteFile(Constants.CONFIG_FILE, data);
        }
    

        public static decimal LoadRestrictionSettings()
        {
            EnsureConfigFileExists();
            var data = parser.ReadFile(Constants.CONFIG_FILE);
            string value = data["Restrictions"].ContainsKey("MaxOrderAgeHours") ? data["Restrictions"]["MaxOrderAgeHours"] : "0.5M";
            return decimal.TryParse(value, out var hours) ? hours : 0.5M;
        }

    }
}
