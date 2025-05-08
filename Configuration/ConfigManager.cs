using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace Tubes_Tahap1_KPL_kelompok3.Configuration
{
    public class ConfigManager
    {
        public AppConfig Config { get; set; }
        private const string configFilePath = "AppConfig.json";

        public ConfigManager()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteConfigFile();
            }
        }

        private void ReadConfigFile()
        {
            string jsonData = File.ReadAllText(configFilePath);
            Config = JsonSerializer.Deserialize<AppConfig>(jsonData);
        }

        private void WriteConfigFile()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(Config, options);
            File.WriteAllText(configFilePath, json);
        }

        private void SetDefault()
        {
            Config = new AppConfig(10, 20, 30, true, false, "Siswa");
        }
    }
}
