using appiumtest.bases;
using appiumtest.common;
using OpenQA.Selenium;
using NUnit.Framework;

using OpenQA.Selenium.Appium.Android;
using System.IO;
namespace appiumtest.testcase
{
    public class Tests : StartEnd
    {
        //[TestCase("username1")]
        //[TestCase("username2")]
        // 使用从CSV读取的数据进行测试
        [Test, TestCaseSource(typeof(TestData), nameof(TestData.GetTestData))]
        public void TestBattery(string username, string password)
        {
            BasePage basePage = new BasePage(_driver);

            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            //By bb = By.XPath("//*[@resource-id='com.android.settings:id/dashboard_tile']");
            // 使用自定义的 XPath 定位方法
            //IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(bb));
            //// 点击元素
            //element.Click();

            //// 滑动屏幕
            //basePage.swipe_screen(0.5, 0.7, 0.5, 0.4, 0.5);

            //// 点击屏幕
            //basePage.click_screen(0.5, 0.5);

            //By bb = By.XPath("//*[@resource-id='com.android.settings:id/dashboard_tile']");
            //IWebElement element =basePage.get_visible_element(bb, 10);
            //element.Click();

            //// 点击设置列表中第一个元素
            //SettingOperations.SettingElementClick(0);


            ////_driver.StartActivity("com.android.settings", "com.android.settings.Settings");
            //_driver.FindElement(By.XPath("//*[@resource-id='com.android.settings:id/dashboard_tile']")).Click();

            // 暂停执行3秒
            Thread.Sleep(3000);

            //var elements = _driver.FindElements(By.XPath("//*[@resource-id='com.android.settings:id/list']/*[@class='android.widget.LinearLayout']"));
            //elements[5].Click();

            //// 暂停执行3秒
            //Thread.Sleep(3000);


            // 在设置首页点击搜索框
            _driver.FindElement(By.Id("com.android.settings:id/search_action_bar")).Click();

            // 在搜索框输入用户名
            _driver.FindElement(By.Id("android:id/search_src_text")).SendKeys(username);


            // 获取并保存屏幕截图
            Screenshot screenshot = _driver.GetScreenshot();
            screenshot.SaveAsFile("d:\\Users\\Desktop\\dotnet-client\\appiumtest\\screenshot\\screenshot.png");

            Assert.AreEqual(1, 2, "断言失败时将进行截图");  // 正确的使用方式

        }
    }

    public class TestData
    {
        /*
            所要读取的csv文件的列名数据结构
         */

        //  该属性的名称必须与CSV文件中列的名称相同（区分大小写）
        public string username { get; set; }
        public string password { get; set; }

        // 提供测试数据：从CSV文件读取并传递给测试
        public static IEnumerable<object[]> GetTestData()
        {
            // 从文件路径读取测试数据
            string filePath = "d:\\Users\\Desktop\\dotnet-client\\appiumtest\\data\\test1.csv";  // 指定你的CSV文件路径
            var testDataList = ParseCsv.ReadTestDataFromCsv(filePath);

            // 将数据转换为适合TestCaseSource的格式
            foreach (var data in testDataList)
            {
                yield return new object[] { data.username, data.password };
            }
        }
    }
}