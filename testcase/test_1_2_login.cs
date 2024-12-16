using appiumtest.bases;
using appiumtest.common;
using appiumtest.Page;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appiumtest.testcase
{
    public class TestLogin_1_2 : StartEnd
    {
        [Test]
        public void TestLoginFuc()
        {
            logger.Info("==========test_login_1_2==========");

            // 点击“体验账号”按钮
            LoginInPageOpn.ExperienceLoginBtn(_driver);

            // 点击“我已了解，立即体验”按钮
            BasePage.get_visible_element(By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/try_btn"), _driver).Click();

            // 在行业选择界面，点击“餐饮行业”按钮
            IndustrySelectionPageOpn.ClickFoodIndustryBtn(_driver);

            // 在选择完“餐饮行业”后，弹出账号列表，滑动账号列表
            BasePage.swipe_screen(0.5, 0.7, 0.5, 0.4, _driver);

            // 在账号列表中，选择“text=chenxunyou12”的账号
            BasePage.get_exists_element(By.XPath("//*[@class='android.widget.LinearLayout']/*[@text='chenxunyou12']"), _driver).Click();

            // 在体验账号登录页面，点击“员工登录”按钮
            TryLogInPageOpn.ClickEmployeeLoginBtn(_driver);

            // 获取“账号密码错误的”Toast提示信息
            string error_toast_msg = TryLogInPageOpn.GetToastText(_driver);

            // 判断Toast提示信息是否为“账号密码错误的”
            CustomAssertions.AssertEqual("收银员账户或者密码出错", error_toast_msg, _driver);
        }
    }
}
