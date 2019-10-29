using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;
using AutoProxy.Services;
using Newtonsoft.Json;
using AutoProxy.Models;
using AutoProxy.Properties;

namespace AutoProxy.Settings
{
    [DataContract]
    public class AutoProxyConfig
    {
        [DataMember(Name = "general")]
        public GeneralSettings General = new GeneralSettings();

        [DataMember(Name = "proxy")]
        public ProxySettings Proxy = new ProxySettings();


        public static AutoProxyConfig Current { get; } = new AutoProxyConfig();

        private readonly string configFilePath = GetDefaultConfigFilePath();

        private AutoProxyConfig()
        {

        }

        private static string GetDefaultConfigFilePath()
        {
            var currentFolderPath = Directory.GetParent(Assembly.GetExecutingAssembly().Location);
            return Path.Combine(currentFolderPath.FullName, "config.json");
        }

        public void LoadConfig()
        {
            if (!File.Exists(configFilePath))
            {
                NotificationService.SendNotify(Resources.CreatedConfigFile, configFilePath);
                SaveConfig();
                return;
            }

            var json = File.ReadAllText(configFilePath, Encoding.UTF8);

            try
            {
                AutoProxyConfig config = JsonConvert.DeserializeObject<AutoProxyConfig>(json,
                    new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Populate });
                this.General = config.General;
                this.Proxy = config.Proxy;
            }
            catch (JsonReaderException e)
            {
                NotificationService.SendNotify(Resources.FailedToLoadConfig, e.Message);
                return;
            }

            ResourceService.Current.ChangeCulture(General.Language);
            NotificationService.SendNotify(Resources.LoadedConfigFile, Proxy.Proxies.Count.ToString());
        }

        public void SaveConfig()
        {
            var json = JsonConvert.SerializeObject(this, Formatting.Indented);
            
            File.WriteAllText(configFilePath, json);
        }
    }
}
