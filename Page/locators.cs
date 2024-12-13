using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace appiumtest.Page
{
    public class SettingLocators
    {
        /*
            设置页面的元素定位器
         */

        // 设置列表的可点击元素
        public static By SettingElements => By.XPath("//*[@resource-id='com.android.settings:id/dashboard_container']/*[@resource-id='com.android.settings:id/dashboard_tile']");
    }

    public class LoginInPageLocators
    {
        /*
         * 登录页元素定位器
         */
        // 账号输入框
        public static By AccountInput => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/account_tv");

        // 密码输入框
        public static By PasswordInput => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/password_tv");

        // 登录按钮
        public static By LoginBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/login_btn");

        // Toast提示
        public static By Toast => By.XPath("//*[@class='android.widget.Toast']");

        // “账号登录”按钮
        public static By AccountLoginBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/login_btn");

        // “体验登录”按钮
        public static By ExperienceLoginBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/try_tv");

        // “免费注册”按钮
        public static By FreeRegisterBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/regist_tv");

        // “联系客服”按钮
        public static By ContactServiceBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/contact_customer_service_ll");

        // “账号+工号登录”按钮
        public static By AccountAndNumberLoginBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/account_cashier_login_ll");
    }
}
