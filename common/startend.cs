using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System.Threading;
using appiumtest.bases;
using NLog;

namespace appiumtest.common
{
    public class StartEnd
    {
        protected AndroidDriver _driver;

        //// 实例化 NLog 日志对象
        //public NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public NLog.Logger logger = LogManager.GetLogger("Mylogger");

        //[OneTimeSetUp]  //  在 所有测试运行前 执行一次初始化
        [SetUp]
        public void SetUp()
        {
            // 获取当前文件的相对路径
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // 构造"config"文件夹路径（当前获取的相对路径通常为“appiumtest\bin\Debug\net9.0\”）
            string configPath = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\config\"));


            // 加载日志的 config 配置文件
            LogManager.Setup().LoadConfigurationFromFile(@Path.GetFullPath(Path.Combine(configPath, "nlog.config")));
            // 设置日志的 config 配置文件中的动态属性
            var logConfig = LogManager.Configuration;
            logConfig.Variables["LogVariable"] = "Log";  // 设置属性值
            // 启动 NLog
            LogManager.ReconfigExistingLoggers();

            // 加载 yinbao App 的 yaml 配置文件
            var _yinbao = Parse_yaml.Parse_yaml_fuc(@Path.GetFullPath(Path.Combine(configPath, "my_yaml.yaml")));
            
            logger.Info("=========setUp===========");

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
            logger.Info("========tearDown=========");
            _driver.Dispose();
            
        }
    }
}