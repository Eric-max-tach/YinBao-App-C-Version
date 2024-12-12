using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System.Threading;
using appiumtest.bases;

namespace appiumtest.common
{
    public class StartEnd
    {
        protected AndroidDriver _driver;

        //[OneTimeSetUp]  //  在 所有测试运行前 执行一次初始化
        [SetUp]
        public void SetUp()
        {
            // YAML 文件路径
            string yamlFilePath = "d:\\Users\\Desktop\\dotnet-client\\appiumtest\\config\\my_yaml.yaml";
            
            // 获取 yinbao App的配置文件
            var _yinbao = Parse_yaml.Parse_yaml_fuc(yamlFilePath);

            var serverUri = new Uri(Environment.GetEnvironmentVariable("APPIUM_HOST") ?? _yinbao.Remoteurl);
            var driverOptions = new AppiumOptions()
            {
                AutomationName = AutomationName.AndroidUIAutomator2,
                PlatformName = _yinbao.PlatformName,    //  平台名
                DeviceName = _yinbao.DeviceName,    //  设备名
            };

            driverOptions.AddAdditionalAppiumOption("appPackage", _yinbao.AppPackage);  //  App包名   
            driverOptions.AddAdditionalAppiumOption("appActivity", _yinbao.AppActivity);    //  App启动Activity名
            // NoReset assumes the app com.google.android is preinstalled on the emulator
            driverOptions.AddAdditionalAppiumOption("noReset", bool.Parse(_yinbao.NoReset));

            // 初始化 AndroidDriver，驱动程序与 Appium 服务器之间的连接超时时间为 180 秒
            _driver = new AndroidDriver(serverUri, driverOptions, TimeSpan.FromSeconds(180));

            // 等待页面加载，可以根据实际情况调整等待时间
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        //[OneTimeTearDown]
        [TearDown]
        public void TearDown()
        {
            _driver.Dispose();
        }
    }
}