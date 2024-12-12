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
        protected static AndroidDriver _driver;

        public BasePage(AndroidDriver driver)
        {
            _driver = driver;
        }

        public IWebElement get_exists_element(By locator, int timeout)
        {
            /*
             *  检查元素是否存在于 DOM 中，但不关心它是否可见，在元素定位的时候添加显式等待功能
             * :param By locator: 元素定位器
             * :param int timeout: 超时时间，单位秒
             */
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));

            try
            {
                // 使用自定义的 By 定位方法
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
                return element;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public IWebElement get_visible_element(By locator, int timeout)
        {
            /*
             *  检查元素是否可见，通常用于确保元素可以与用户交互，在元素定位的时候添加显式等待功能
             * :param By locator: 元素定位器
             * :param int timeout: 超时时间，单位秒
             */
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));

            try
            {
                // 使用自定义的 By 定位方法
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                return element;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public IWebElement get_clickable_element(By locator, int timeout)
        {
            /*
             *  检查元素是否可点击，在元素定位的时候添加显式等待功能
             * :param By locator: 元素定位器
             * :param int timeout: 超时时间，单位秒
             */
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));

            try
            {
                // 使用自定义的 By 定位方法
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
                return element;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static IList<IWebElement> get_exists_elements(By locator, int timeout)
        {
            /*
             *  获取一组存在的元素，但不一定可见，在元素定位的时候添加显式等待功能
             * :param By locator: 元素定位器
             * :param int timeout: 超时时间，单位秒
             */
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));

            try
            {
                // 使用自定义的 By 定位方法
                IList<IWebElement> elements = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
                return elements;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public void swipe_screen(double startX, double startY, double endX, double endY, double duration = 1)
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
            // 获取屏幕的尺寸
            var size = _driver.Manage().Window.Size;

            // 将百分比坐标转化为实际坐标
            int startXPixel = (int)(size.Width * startX);
            int startYPixel = (int)(size.Height * startY);
            int endXPixel = (int)(size.Width * endX);
            int endYPixel = (int)(size.Height * endY);

            // 使用 W3C Actions 进行屏幕滑动
            Actions action = new Actions(_driver);

            // 执行滑动动作
            action.MoveToLocation(startXPixel, startYPixel)
                .ClickAndHold()
                .MoveToLocation(endXPixel, endYPixel)
                .Pause(TimeSpan.FromSeconds(duration))
                .Release()
                .Perform();
        }

        public void click_screen(double startX, double startY, double duration = 0.5)
        {
            /*
                屏幕点击
                :param start_x: 点击横坐标
                :param start_y: 点击纵坐标
                :param duration: 点击持续时间，单位为s
             */
            // 获取屏幕的尺寸
            var size = _driver.Manage().Window.Size;

            // 将百分比坐标转化为实际坐标
            int startXPixel = (int)(size.Width * startX);
            int startYPixel = (int)(size.Height * startY);

            // 使用 W3C Actions 进行屏幕点击动作
            Actions action = new Actions(_driver);

            // 执行点击动作
            action.MoveToLocation(startXPixel, startYPixel)
                .ClickAndHold()
                .Pause(TimeSpan.FromSeconds(duration))
                .Release()
                .Perform();
        }
    }
}