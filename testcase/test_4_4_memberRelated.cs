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
    public class TestLogin_4_4 : StartEnd
    {
        // 使用从CSV读取的数据进行测试
        [Test]
        public void TestRechargeAndCouponIssue()
        {
            logger.Info("==========test_RechargeAndCouponIssue==========");

            // 点击“体验账号”按钮
            LoginInPageOpn.ExperienceLoginBtn(_driver);

            // 点击“我已了解，立即体验”按钮
            BasePage.get_exists_element(By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/try_btn"), _driver).Click();

            // 点击“餐饮行业”按钮
            IndustrySelectionPageOpn.ClickFoodIndustryBtn(_driver);

            // 选择“text=pspldemo0082”的账号
            BasePage.get_exists_element(By.XPath("//*[@class='android.widget.LinearLayout']/*[@text='pspldemo0082']"), _driver).Click();
            Thread.Sleep(15000);


            // 点击"自用品(收银用)"分类按钮
            string categroyName = CashInterfacePageOpn.ClickCategoryBtn(3, _driver);

            // 从当前屏幕所显示的菜品中随机选择两个商品
            SortedDictionary<string, string> productNames = new SortedDictionary<string, string>();
            SortedDictionary<string, string> productPrices = new SortedDictionary<string, string>();
            Random random = new Random();
            int actualProductCount = Math.Min(19, )
        }
    }
}
