//using appiumtest.bases;
//using appiumtest.common;
//using OpenQA.Selenium;
//using NUnit.Framework;

//using OpenQA.Selenium.Appium.Android;
//using System.IO;
//using appiumtest.common;
//using NLog;
//using Allure.Commons;
//using NUnit.Allure.Attributes;

//namespace appiumtest.testcase
//{
//    public class Tests : StartEnd
//    {
//        // 使用从CSV读取的数据进行测试
//        [Test, TestCaseSource(typeof(TestData), nameof(TestData.GetTestData))]
//        public void TestBattery(string username, string password)
//        {
//            logger.Info("tt");
//            BasePage basePage = new BasePage(_driver);
//            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
//            //By bb = By.XPath("//*[@resource-id='com.android.settings:id/dashboard_tile']");
//            // 使用自定义的 XPath 定位方法
//            //IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(bb));
//            //// 点击元素
//            //element.Click();

//            //// 滑动屏幕
//            //basePage.swipe_screen(0.5, 0.7, 0.5, 0.4, 0.5);

//            //// 点击屏幕
//            //basePage.click_screen(0.5, 0.5);

//            //By bb = By.XPath("//*[@resource-id='com.android.settings:id/dashboard_tile']");
//            //IWebElement element =basePage.get_visible_element(bb, 10);
//            //element.Click();

//            //// 点击设置列表中第一个元素
//            //SettingOperations.SettingElementClick(0);


//            ////_driver.StartActivity("com.android.settings", "com.android.settings.Settings");
//            //_driver.FindElement(By.XPath("//*[@resource-id='com.android.settings:id/dashboard_tile']")).Click();

//            // 暂停执行3秒
//            //Thread.Sleep(3000);

//            //var elements = _driver.FindElements(By.XPath("//*[@resource-id='com.android.settings:id/list']/*[@class='android.widget.LinearLayout']"));
//            //elements[5].Click();

//            //// 暂停执行3秒
//            //Thread.Sleep(3000);


//            //// 在设置首页点击搜索框
//            //_driver.FindElement(By.Id("com.android.settings:id/search_action_bar")).Click();

//            //// 在搜索框输入用户名
//            //_driver.FindElement(By.Id("android:id/search_src_text")).SendKeys(username);

//            // 测试 basepage 获取元素失败截图功能
//            basePage.get_exists_element(By.Id("non_existent_element_id"), 1);

//            //// 获取元素失败
//            //try
//            //{
//            //    // 尝试找到一个不存在的元素，模拟元素定位失败
//            //    IWebElement element = _driver.FindElement(By.Id("non_existent_element_id"));

//            //    // 如果找到了元素，则执行某些操作
//            //    element.Click();
//            //}
//            //catch (NoSuchElementException ex)
//            //{
//            //    Console.WriteLine("=======================错误开始=====================");
//            //    // 捕获元素找不到的异常
//            //    Console.WriteLine($"元素未找到: {ex.Message}");


//            //    Console.WriteLine("qianyanyi");

//            //    // 如果需要，也可以重新抛出异常
//            //    Console.WriteLine("=======================错误结束=====================");
//            //}

//            //// 断言失败
//            //CustomAssertions.AssertEqual(2, 2);

//            //// 滑动屏幕
//            //basePage.swipe_screen(0.5, 0.7, 0.5, 0.4, 0.5);
//            //Console.WriteLine("new line+++++++++++++++");

//        }
//    }

//    public class TestData
//    {
//        /*
//            所要读取的csv文件的列名数据结构
//         */

//        //  该属性的名称必须与CSV文件中列的名称相同（区分大小写）
//        public string username { get; set; }
//        public string password { get; set; }

//        // 提供测试数据：从CSV文件读取并传递给测试
//        public static IEnumerable<object[]> GetTestData()
//        {
//            // 获取当前文件的相对路径
//            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
//            // 构造"data"文件夹路径（当前获取的相对路径通常为“appiumtest\bin\Debug\net9.0\”）
//            string dataPath = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\data\"));

//            // 从文件路径读取测试数据
//            string filePath = dataPath + "test_1_1_login.csv";  // 指定你的CSV文件路径
//            var testDataList = ParseCsv.ReadTestDataFromCsv(filePath);

//            // 将数据转换为适合TestCaseSource的格式
//            foreach (var data in testDataList)
//            {
//                yield return new object[] { data.username, data.password };
//            }
//        }
//    }
//}