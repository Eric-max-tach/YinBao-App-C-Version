using appiumtest.bases;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace appiumtest.Page
{
    class LoginScenario : BasePage
    {
        /*
         * 定义了与登录相关的场景
         */
        public void FillinUserAndPwdAndLogin(string username, string password, AndroidDriver driver)
        {
            /*
             * 在登录界面，输入账号和密码，并点击登录按钮
             */
            // 在登录页面的账号输入框中输入用户名
            LoginInPageOpn.InputUsername(username, driver);

            // 在登录页面的密码输入框中输入密码
            LoginInPageOpn.InputPassword(password, driver);

            // 点击登录按钮
            LoginInPageOpn.ClickLoginBtn(driver);

        }
    }

    class NotAvailableCouponPageScenario : BasePage
    {
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");
        /*
         * 定义了不可用优惠券页面相关的场景
         */
        // 统计“不可用优惠券”页面下，未生效优惠券的数量，用字典记录每一条优惠券号码，并返回该字典
        public static IList<SortedDictionary<string, string>> GetUnavailableCouponList(AndroidDriver driver, SortedDictionary<string, string> couponNumberDict, SortedDictionary<string, string> couponNumberExtendDict = null, bool is_first = true)
        {
            /*
             * 统计“不可用优惠券”页面下，“未生效”优惠券的数量，用字典记录每一条优惠券号码，并返回该字典

             * :param dict coupon_number_dic:   统计“未生效”优惠券编号的字典，默认为空
             * :param dict coupon_number_extend_dic:    统计添加新的“未生效”优惠券后，记录新增“未生效”优惠券编号的字典，默认为空
             * :param bool is_first: 判断是否为第一次统计“未生效”优惠券编号，如果是第一次统计，则将记录信息添加到coupon_number_dic字典中。如果不是第一次统计，则将记录信息添加到coupon_number_extend_dic字典中
             * :return: 统计“未生效”优惠券编号的字典， 新增“未生效”优惠券编号的字典
             */

            // 获取“未生效优惠券”视图框列表的大小，并返回视图框左上角和右下角的坐标值
            int[] viewBox = NotAvailableCouponPageOpn.GetUnavailableCouponViewBox(driver);
            int topLeftX = viewBox[0];
            int topLeftY = viewBox[1];
            int lowerRightX = viewBox[2];
            int lowerRightY = viewBox[3];

            // 判断是否已经滑动到列表底部的标志位
            string lastCouponNumberIndex = "0";

            // 获取屏幕的大小
            int screenWidth = driver.Manage().Window.Size.Width;
            int screenHeight = driver.Manage().Window.Size.Height;

            // 统计优惠券号码
            while (true)
            {
                // 获取当前显示在“未生效”视图中，优惠券号码元素列表
                IList<IWebElement> couponNumberElements = NotAvailableCouponPageOpn.GetUnavailableCouponList(driver);
                for (int i = 0; i < couponNumberElements.Count; i++)
                {
                    string couponNumber = couponNumberElements[i].Text;
                    if (is_first)
                    {
                        if (!couponNumberDict.ContainsKey(couponNumber))
                        {
                            logger.Info("添加优惠券号码：" + couponNumber + " 到couponNumberDict字典中");  // 如果优惠券号码已存在，则打印提示信息
                            couponNumberDict.Add(couponNumber, "已存在");  // 如果是第一次统计，则将记录添加到coupon_number_dic字典中
                        }
                    }
                    else
                    {
                        if (!couponNumberDict.ContainsKey(couponNumber) && !couponNumberExtendDict.ContainsKey(couponNumber))
                        {
                            logger.Info("添加优惠券号码：" + couponNumber + " 到couponNumberExtendDict字典中");  // 如果优惠券号码已存在，则打印提示信息
                            couponNumberExtendDict.Add(couponNumber, "已存在");  // 如果不是第一次统计，则将记录添加到coupon_number_extend
                        }
                    }
                }
                if (lastCouponNumberIndex.Equals(couponNumberElements[couponNumberElements.Count - 1].Text))    // 用于判断是否滑动到列表底部
                {
                    break;
                }
                lastCouponNumberIndex = couponNumberElements[couponNumberElements.Count - 1].Text;

                // 滑动“小吃券”列表
                swipe_screen((((lowerRightX + topLeftX) * 0.5) / screenWidth),
                        (lowerRightY * 0.85) / screenHeight,
                         (((lowerRightX + topLeftX) * 0.5) / screenWidth),
                           ((lowerRightY * 0.6) / screenHeight), driver);

                //// 清空列表
                //couponNumberElements.Clear();
            }

            return new List<SortedDictionary<string, string>>() { couponNumberDict, couponNumberExtendDict };
        }
    }

    public class PointExchangePageScenarios : BasePage
    {
        /*
         * 定义了积分兑换页面相关的场景
         */
        // 获得"积分兑换商品"列表的最后一个元素的名称
        public static string GetLastItemName(AndroidDriver driver)
        {
            /*
             * 获取"积分兑换商品"列表的最后一个元素的名称
             */
            // 获取“兑换商品”视图框列表的大小，得到视图框左上角和右下角的坐标值，即"[480,92][1440,1080]"
            int[] viewBox = PointExchangePageOpn.GetPointExchangeViewBox(driver);
            int topLeftX = viewBox[0];
            int topLeftY = viewBox[1];
            int lowerRightX = viewBox[2];
            int lowerRightY = viewBox[3];

            // 获取屏幕的大小
            int screenWidth = driver.Manage().Window.Size.Width;
            int screenHeight = driver.Manage().Window.Size.Height;

            // 判断是否已经滑动到列表底部的标志位
            string lastItemName = "";

            // 滑动到列表底部
            while (true)
            {
                // 获取当前显示在“兑换商品”视图中，品名元素列表
                if (lastItemName.Equals(PointExchangePageOpn.GetPointExchangeItemTitle(driver, -1)))
                {
                    break;
                }
                lastItemName = PointExchangePageOpn.GetPointExchangeItemTitle(driver, -1);

                // 滑动“积分兑换”列表
                swipe_screen((((lowerRightX + topLeftX) * 0.5) / screenWidth),
                            (lowerRightY * 0.9) / screenHeight,
                             (((lowerRightX + topLeftX) * 0.5) / screenWidth),
                               ((topLeftY * 0.5) / screenHeight), driver);
            }

            return lastItemName;
        }
    }
}