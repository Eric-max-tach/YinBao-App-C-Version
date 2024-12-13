using appiumtest.bases;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appiumtest.Page
{
    public class LoginInPageOpn : BasePage
    {
        // 实例化 NLog 日志对象
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");

        public static void InputUsername(string username, AndroidDriver driver)
        {
            /*
                账号输入框输入账号名

                :param str username: 账号名

                Example
                -------
                >>> username = "Eric"
                >>> LoginInPageOpn(self.driver).input_account(username)
             */
            logger.Info("==========input_username==========");
            IWebElement ele = get_exists_element(LoginInPageLocators.AccountInput, driver);
            ele.SendKeys(username);
        }

        public static void InputPassword(string password, AndroidDriver driver)
        {
            /*
                密码输入框输入密码

                :param str password: 密码

                Example
                -------
                >>> username = "Eric"
                >>> LoginInPageOpn(self.driver).input_account(username)
             */
            logger.Info("==========input_password==========");
            IWebElement ele = get_exists_element(LoginInPageLocators.PasswordInput, driver);
            ele.SendKeys(password);
        }

        public static void ClickLoginBtn(AndroidDriver driver)
        {
            /*
                密码输入框输入密码
             */
            logger.Info("==========click_login_btn==========");
            IWebElement ele = get_exists_element(LoginInPageLocators.LoginBtn, driver);
            ele.Click();
        }

        public static string GetToastText(AndroidDriver driver)
        {
            /*
                获取Toast文本信息
             */
            logger.Info("==========get_toast_text==========");
            IWebElement ele = get_exists_element(LoginInPageLocators.Toast, driver);
            return ele.Text;
        }

        public static void ExperienceLoginBtn(AndroidDriver driver)
        {
            /*
                体验账号按钮点击
             */
            logger.Info("==========experience_login_btn==========");
            IWebElement ele = get_exists_element(LoginInPageLocators.ExperienceLoginBtn, driver);
            ele.Click();
        }

        public static void FreeRegisterBtn(AndroidDriver driver)
        {
            /*
                免费注册按钮点击
             */
            logger.Info("==========free_register_btn==========");
            IWebElement ele = get_exists_element(LoginInPageLocators.FreeRegisterBtn, driver);
            ele.Click();
        }

        public static void ContactServiceBtn(AndroidDriver driver)
        {
            /*
                联系客服按钮点击
             */
            logger.Info("==========contact_service_btn==========");
            IWebElement ele = get_exists_element(LoginInPageLocators.ContactServiceBtn, driver);
            ele.Click();
        }

        public static void AccountAndNumberLoginBtn(AndroidDriver driver)
        {
            /*
                账号+工号登录按钮点击
             */
            logger.Info("==========account_and_number_login_btn==========");
            IWebElement ele = get_exists_element(LoginInPageLocators.AccountAndNumberLoginBtn, driver);
            ele.Click();
        }
    }
}
