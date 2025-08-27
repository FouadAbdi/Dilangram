using System;
using System.Configuration;
using System.IO;

namespace Dilangram.Config
{
    public static class AppConfig
    {
        /// <summary>
        /// Gets the Telegram API ID from app.config or returns default
        /// </summary>
        public static int ApiId
        {
            get
            {
                string value = ConfigurationManager.AppSettings["TelegramApiId"];
                if (int.TryParse(value, out int apiId))
                {
                    return apiId;
                }
                // Return default if not found in config
                return 20833282;
            }
        }

        /// <summary>
        /// Gets the Telegram API Hash from app.config or returns default
        /// </summary>
        public static string ApiHash
        {
            get
            {
                string value = ConfigurationManager.AppSettings["TelegramApiHash"];
                if (!string.IsNullOrEmpty(value))
                {
                    return value;
                }
                // Return default if not found in config
                return "6d4517a3e6c32f17e5ac2efe026039e2";
            }
        }

        /// <summary>
        /// Creates or updates the app.config file with current API credentials
        /// </summary>
        public static void CreateConfigFile()
        {
            try
            {
                string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dilangram.exe.config");
                
                if (!File.Exists(configPath))
                {
                    string configContent = @"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
    <startup>
        <supportedRuntime version=""v4.0"" sku="".NETFramework,Version=v4.8.1"" />
    </startup>
    
    <appSettings>
        <!-- Telegram API Configuration -->
        <add key=""TelegramApiId"" value=""20833282"" />
        <add key=""TelegramApiHash"" value=""6d4517a3e6c32f17e5ac2efe026039e2"" />
    </appSettings>
</configuration>";
                    
                    File.WriteAllText(configPath, configContent);
                    Program.Log("Configuration file created: " + configPath);
                }
                else
                {
                    Program.Log("Configuration file already exists: " + configPath);
                }
            }
            catch (Exception ex)
            {
                Program.Log($"Error creating config file: {ex.Message}");
            }
        }
    }
}
