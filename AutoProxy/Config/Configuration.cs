﻿using System.IO;
using System.Collections.Generic;
using System.Text;
using AutoProxy.Services;
using Newtonsoft.Json;

namespace AutoProxy.Config
{
    public class Configuration
    {

        private AutoProxyConfig _config = new AutoProxyConfig();

        public static Configuration Instance { get; }= new Configuration();

        private Configuration()
        {

        }

        public void LoadConfig(string configFilePath)
        {
            if (!File.Exists(configFilePath))
            {
                NotificationService.SendNotify("設定ファイルの読み込みに失敗しました。", $"File not found: {configFilePath}");
                return;
            }
            var json = File.ReadAllText(configFilePath, Encoding.UTF8);

            try
            {
                _config = JsonConvert.DeserializeObject<AutoProxyConfig>(json,
                    new JsonSerializerSettings {DefaultValueHandling = DefaultValueHandling.Populate});
            }
            catch (JsonReaderException e)
            {
                NotificationService.SendNotify("設定ファイルの読み込みに失敗しました。", e.Message);
            }

        }

        public void SaveConfig(string configFilePath)
        {
            var json = JsonConvert.SerializeObject(_config, Formatting.Indented);
            
            File.WriteAllText(configFilePath, json);
        }

        public void AddSetting(ProxySetting setting)
        {
            _config.Proxies.Add(setting);
        }

        public List<ProxySetting> FindSetting(string ssidToFind)
        {
            return _config.Proxies.FindAll(s => s.SSID == ssidToFind);
        }

    }
}