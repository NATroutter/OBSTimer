using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OBSTimer {
    public class Settings {

        private string settingsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");

        public SettingsData data { get; set; } = new SettingsData();

        public void load() {
            if (!File.Exists(settingsFile)) {
                File.Create(settingsFile).Close();
            }

            using (StreamReader file = File.OpenText(settingsFile)) {
                using (JsonTextReader reader = new JsonTextReader(file)) {
                    JsonSerializer serializer = new JsonSerializer();
                    var raw = serializer.Deserialize<SettingsData>(reader);
                    if (raw != null) { data = raw; }
                }
            }
        }

        public void save() {
            using (StreamWriter file = File.CreateText(settingsFile)) {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }

    }
}
