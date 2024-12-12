using System;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace appiumtest.bases
{
    public class Config
    {
        // App配置信息
        public Yinbao Yinbao { get; set; }
    }

    public class Yinbao
    {
        // 平台名称
        public string PlatformName { get; set; }

        // 平台版本
        public string PlatformVersion { get; set; }

        // 设备名称
        public string DeviceName { get; set; }

        // app包名
        public string AppPackage { get; set; }

        // app入口activity
        public string AppActivity { get; set; }

        // Appium服务器地址
        public string Remoteurl { get; set; }

        public string NoReset { get; set; }
    }
    public class Parse_yaml
    {
        public static Yinbao Parse_yaml_fuc(string yamlFilePath)
        {
            // YAML 文件路径
            //string yamlFilePath = "d:\\Users\\Desktop\\dotnet-client\\appiumtest\\config\\my_yaml.yaml";

            // 读取YAML文件内容
            var yamlContent = File.ReadAllText(yamlFilePath);

            // 创建反序列化器
            var deserilizer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance) // 支持驼峰命名
                .Build();

            // 反序列化YAML数据为C#对象
            var config = deserilizer.Deserialize<Config>(yamlContent);

            // 返回序列化对象
            return config.Yinbao;
        }
    }
}
