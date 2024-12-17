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
    public class TestLogin_2_1 : StartEnd
    {
        [Test]
        public void TestMessageClearFuc()
        {
            logger.Info("==========test_MessageClear==========");

            // 点击“体验账号”按钮
            LoginInPageOpn.ExperienceLoginBtn(_driver);

            // 点击“我已了解，立即体验”按钮
            BasePage.get_exists_element(By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/try_btn"), _driver).Click();

            // 点击“餐饮行业”按钮
            IndustrySelectionPageOpn.ClickFoodIndustryBtn(_driver);

            // 选择“text=pspldemo0082”的账号
            BasePage.get_exists_element(By.XPath("//*[@class='android.widget.LinearLayout']/*[@text='pspldemo0082']"), _driver).Click();
            Thread.Sleep(15000);

            // 在“收银”页面，点击“未读消息”按钮
            CashInterfacePageOpn.ClickUnreadMessageBtn(_driver);

            // 在“收银”页面，点击“库存预警”按钮
            BasePage.click_screen(0.1875, 0.4741, _driver);

            // 在“消息中心”页面，点击“库存预警”按钮
            MessageCenterPageOpn.ClickStockWarningBtn(_driver);

            // 在“消息中心”页面，获取“库存预警”的数量
            int inventoryWarningNum = MessageCenterPageOpn.GetStockWarningCount(_driver);
            logger.Info("“库存预警”的数量为：{}", inventoryWarningNum);

            // 如果库存预警数量大于0，则执行下一步操作
            if (inventoryWarningNum > 0)
            {
                // 在“消息中心”页面，点击“全选”按钮
                MessageCenterPageOpn.ClickSelectAllBtn(_driver);

                // 在“消息中心”页面，点击“忽略此商品”按钮
                MessageCenterPageOpn.ClickIgnoreBtn(_driver);

                // 在“消息中心”页面，再次获取“库存预警”的数量
                int inventoryWarningNumNew = MessageCenterPageOpn.GetStockWarningCount(_driver);

                // 判断“库存预警”数量是否为0
                CustomAssertions.AssertEqual(0, inventoryWarningNumNew, _driver);
            }

            // 在“消息中心”页面，点击“页面返回”按钮，进入“收银”页面
            MessageCenterPageOpn.ClickBackBtn(_driver);
        }
    }
}
