using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Interactions;

namespace appiumtest.bases
{
    public class BasePage: Object
    {
        public static IWebElement get_exists_element(By locator, AndroidDriver driver, IWebElement parent_element = null, int timeout = 1)
        {
            /*
             *  检查元素是否存在于 DOM 中，但不关心它是否可见，在元素定位的时候添加显式等待功能
             * :param By locator: 元素定位器
             * :param int timeout: 超时时间，单位秒
             */
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            if (parent_element == null)
            {
                try
                {
                    // 使用自定义的 By 定位方法
                    return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
                }
                catch (Exception e)
                {
                    // 生成元素未找到的截图信息
                    generate_screenshot(1, driver);

                    Console.WriteLine(e.Message);
                    Console.WriteLine("元素未找到，请检查定位器是否正确或页面是否存在该元素");
                    return null;
                }
            }
            else
            {
                try
                {
                    // 使用自定义的 By 定位方法
                    // 在父级元素范围内查找子元素
                    return wait.Until(_ =>
                             parent_element.FindElement(locator));
                    
                }
                catch (Exception e)
                {
                    // 生成元素未找到的截图信息
                    generate_screenshot(1, driver);

                    Console.WriteLine(e.Message);
                    Console.WriteLine("元素未找到，请检查定位器是否正确或页面是否存在该元素");
                    return null;
                }
            }
        }

        public static IWebElement get_visible_element_need_exception(By locator, AndroidDriver driver, IWebElement parent_element = null, int timeout = 1, int need_screenshot = 1)
        {
            /*
             * 该方法会返回异常信息
            获取存在，但不一定可见的元素，在元素定位的时候添加显式等待功能
            :param locator: By方法定位元素，如（By.XPATH, "//*[@class='frank]"）
            :param timeout:
            :param element: 通过所提供的元素查找该元素的子元素
            :param need_screenshot: 判断是否出现异常时需要截图，默认值为1，表示需要异常截图。0表示不需要异常截图
            :return: 返回存在，但不一定可见的元素
            */
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            if (parent_element == null)
            {
                try
                {
                    // 使用自定义的 By 定位方法
                    return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
                }
                catch (Exception e)
                {
                    if (need_screenshot == 1)
                    {
                        // 生成元素未找到的截图信息
                        generate_screenshot(1, driver);

                        Console.WriteLine(e.Message);
                        Console.WriteLine("元素未找到，请检查定位器是否正确或页面是否存在该元素");
                    }

                    throw e;
                }
            }
            else
            {
                try
                {
                    // 使用自定义的 By 定位方法
                    // 在父级元素范围内查找子元素
                    return wait.Until(_ =>
                             parent_element.FindElement(locator));

                }
                catch (Exception e)
                {
                    if (need_screenshot == 1)
                    {
                        // 生成元素未找到的截图信息
                        generate_screenshot(1, driver);

                        Console.WriteLine(e.Message);
                        Console.WriteLine("元素未找到，请检查定位器是否正确或页面是否存在该元素");
                    }

                    throw e;
                }
            }


        }

        public static IWebElement get_visible_element(By locator, AndroidDriver driver, int timeout = 1)
        {
            /*
             *  检查元素是否可见，通常用于确保元素可以与用户交互，在元素定位的时候添加显式等待功能
             * :param By locator: 元素定位器
             * :param int timeout: 超时时间，单位秒
             */
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));

            try
            {
                // 使用自定义的 By 定位方法
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                return element;
            }
            catch (Exception e)
            {
                // 生成元素未找到的截图信息
                generate_screenshot(1, driver);

                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static IWebElement get_clickable_element(By locator, int timeout, AndroidDriver driver)
        {
            /*
             *  检查元素是否可点击，在元素定位的时候添加显式等待功能
             * :param By locator: 元素定位器
             * :param int timeout: 超时时间，单位秒
             */
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));

            try
            {
                // 使用自定义的 By 定位方法
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
                return element;
            }
            catch (Exception e)
            {
                // 生成元素未找到的截图信息
                generate_screenshot(1, driver);

                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static IList<IWebElement> get_exists_elements(By locator, AndroidDriver driver, int timeout = 1)
        {
            /*
             *  获取一组存在的元素，但不一定可见，在元素定位的时候添加显式等待功能
             * :param By locator: 元素定位器
             * :param int timeout: 超时时间，单位秒
             */
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));

            try
            {
                // 使用自定义的 By 定位方法
                IList<IWebElement> elements = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
                return elements;
            }
            catch (Exception e)
            {
                // 生成元素未找到的截图信息
                generate_screenshot(1, driver);

                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static void swipe_screen(double startX, double startY, double endX, double endY, AndroidDriver driver, double duration = 1)
        {
            /*
                屏幕滑动
                :param start_x: 滑动起始点横坐标
                :param start_y: 滑动起始点纵坐标
                :param end_x: 滑动结束点横坐标
                :param end_y: 滑动结束点纵坐标
                :param duration: 滑动持续时间，单位为s，即滑动屏幕的时候是否需要惯性，默认为空值即有惯性，若值越大则不存在惯性，一般设置为0.5s
                :return:

                注意：上述位置信息指的是百分比，例如x轴的二分之一处，传入的值则为0.5
             */
            try
            {
                // 获取屏幕的尺寸
                var size = driver.Manage().Window.Size;

                // 将百分比坐标转化为实际坐标
                int startXPixel = (int)(size.Width * startX);
                int startYPixel = (int)(size.Height * startY);
                int endXPixel = (int)(size.Width * endX);
                int endYPixel = (int)(size.Height * endY);

                // 使用 W3C Actions 进行屏幕滑动
                Actions action = new Actions(driver);

                // 执行滑动动作
                action.MoveToLocation(startXPixel, startYPixel)
                    .ClickAndHold()
                    .MoveToLocation(endXPixel, endYPixel)
                    .Pause(TimeSpan.FromSeconds(duration))
                    .Release()
                    .Perform();
            }
            catch (Exception e)
            {
                // 生成截图信息
                generate_screenshot(3, driver, "swipe_screen_error");

                Console.WriteLine(e.Message);
            }
        }

        public void click_screen(double startX, double startY, AndroidDriver driver, double duration = 0.5)
        {
            /*
                屏幕点击
                :param start_x: 点击横坐标
                :param start_y: 点击纵坐标
                :param duration: 点击持续时间，单位为s
             */
            try
            { // 获取屏幕的尺寸
                var size = driver.Manage().Window.Size;

                // 将百分比坐标转化为实际坐标
                int startXPixel = (int)(size.Width * startX);
                int startYPixel = (int)(size.Height * startY);

                // 使用 W3C Actions 进行屏幕点击动作
                Actions action = new Actions(driver);

                // 执行点击动作
                action.MoveToLocation(startXPixel, startYPixel)
                    .ClickAndHold()
                    .Pause(TimeSpan.FromSeconds(duration))
                    .Release()
                    .Perform();
            }
            catch (Exception e)
            {
                // 生成截图信息
                generate_screenshot(3, driver, "click_screen");

                Console.WriteLine(e.Message);
            }
        }

        public static void generate_screenshot(int exception_type, AndroidDriver driver, string message = "")
        {
            /*
                生成屏幕截图
                :param exception_type: 1-元素未找到异常，2-断言异常，3-其他异常
                :param message: 异常信息
             */
            // 获取当前时间的时间戳，用于生成唯一的文件名
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            // 获取相对路径
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // 构造相对路径（假设文件在项目根目录下的 data 文件夹中）
            string relativePath = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\screenshot\"));
            // 生成文件名
            string fileName = "";
            if (exception_type == 1)
            {
                // 元素未找到异常
                relativePath += @"element_not_found\";
                message = "element_not_found";
                // 生成文件名
                fileName = Path.Combine(relativePath, $"{message}_{timestamp}.png");
            }
            else if (exception_type == 2)
            {
                // 断言异常
                relativePath += @"assert_exception\";
                message = "assert_exception";
                // 生成文件名
                fileName = Path.Combine(relativePath, $"{message}_{timestamp}.png");
            }
            else
            {
                // 其他异常
                relativePath += @"other_exception\";
                // 生成文件名
                fileName = Path.Combine(relativePath, $"{message}_{timestamp}.png");
            }

            // 创建目录
            if (!Directory.Exists(relativePath))
            {
                Directory.CreateDirectory(relativePath);
            }


            // 保存屏幕截图
            Screenshot screenshot = driver.GetScreenshot();
            screenshot.SaveAsFile(fileName);
        }
    }
}