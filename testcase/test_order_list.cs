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
    public class Test_order_list : StartEnd
    {
        [Test]
        public void TestOrderListFuc()
        {
            logger.Info("TestOrderListFuc start");

            //// 在“用户登陆”页面，输入用户名
            //LoginInPageOpn.InputUsername("13883270786", _driver);

            //// 在“用户登陆”页面，输入密码
            //LoginInPageOpn.InputPassword("Qyy13883270786", _driver);

            //// 在“用户登陆”页面，点击“登陆”按钮，进入“体验账号登录”页面
            //LoginInPageOpn.ClickLoginBtn(_driver);

            //// 在“体验账号登录”页面，输入工号
            //TryLogInPageOpn.InputJobNumber("123", _driver);

            //// 在“体验账号登录”页面，输入密码
            //TryLogInPageOpn.InputPassword("Qyy13883270786", _driver);

            //// 在“体验账号登录”页面，点击“员工登录”按钮
            //TryLogInPageOpn.ClickEmployeeLoginBtn(_driver);

            //// 在“收银”页面，点击第一个分类（饮料）下的第一个商品（可乐）和第二个商品（雪碧）
            //IList<IWebElement> eles = BasePage.get_exists_elements(CashInterfacePageLocators.GoodsList, _driver);
            //eles[0].Click();
            //eles[1].Click();

            //// 在“收银”页面，点击“点击选择会员”按钮
            //CashInterfacePageOpn.ClickChooseMemberBtn(_driver);

            //// 在“选择会员”页面，输入会员卡号“1”
            //SelectMemberPageOpn.InputNumber1(_driver);

            //// 在“选择会员”页面，点击“确定”按钮
            //SelectMemberPageOpn.ClickConfirmBtn(_driver);

            //// 在“会员详情”页面，点击“选择会员”按钮
            //MembershipDetailsPageOpn.ClickSelectMemberBtn(_driver);

            //// 在“收银”页面，获得订单的总额
            //string total_price = CashInterfacePageOpn.GetTotalAmountText(_driver);

            //// 在“收银”页面，获得订单的实收金额
            //string actual_price = CashInterfacePageOpn.GetActualAmountText(_driver);

            //// 在“收银”页面，点击“收银”按钮
            //CashInterfacePageOpn.ClickCashBtn(_driver);

            //// 在“结账详情页”页面，点击“确定”按钮
            //RechargeDetailPageOpn.ClickConfirmBtn(_driver);

            // 打开“我的店铺app”的登录页面
            _driver.StartActivity("cn.pospal.myshopv3", ".MainActivity");
        }
    }
}
