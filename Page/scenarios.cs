using appiumtest.bases;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appiumtest.Page
{
    class LoginScenario: BasePage
    {
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
}
