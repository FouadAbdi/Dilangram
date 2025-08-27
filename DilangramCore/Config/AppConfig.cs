using System.Configuration;

namespace DilangramCore.Config
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
                string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DilangramCore.dll.config");
                
                if (!File.Exists(configPath))
                {
                    string configContent = @"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
    <appSettings>
        <!-- Telegram API Configuration -->
        <add key=""TelegramApiId"" value=""20833282"" />
        <add key=""TelegramApiHash"" value=""6d4517a3e6c32f17e5ac2efe026039e2"" />
    </appSettings>
</configuration>";
                    
                    File.WriteAllText(configPath, configContent);
                    Dilangram.Program.Log("Configuration file created: " + configPath);
                }
                else
                {
                    Dilangram.Program.Log("Configuration file already exists: " + configPath);
                }
            }
            catch (Exception ex)
            {
                Dilangram.Program.Log($"Error creating config file: {ex.Message}");
            }
        }
    }
}
