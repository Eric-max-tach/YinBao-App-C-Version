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
    public class TestLogin_4_1 : StartEnd
    {
        // 使用从CSV读取的数据进行测试
        [Test]
        public void TestRechargeAndCouponIssue()
        {
            logger.Info("==========test_AddGoods==========");

            // 点击“体验账号”按钮
            LoginInPageOpn.ExperienceLoginBtn(_driver);

            // 点击“我已了解，立即体验”按钮
            BasePage.get_exists_element(By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/try_btn"), _driver).Click();

            // 点击“餐饮行业”按钮
            IndustrySelectionPageOpn.ClickFoodIndustryBtn(_driver);

            // 选择“text=pspldemo0082”的账号
            BasePage.get_exists_element(By.XPath("//*[@class='android.widget.LinearLayout']/*[@text='pspldemo0082']"), _driver).Click();
            Thread.Sleep(15000);

            // 点击“点击选择会员”按钮
            CashInterfacePageOpn.ClickChooseMemberBtn(_driver);

            // 在“选择会员”页面，点击“5”按钮
            SelectMemberPageOpn.InputNumber5(_driver);

            // 在“选择会员”页面，点击“确定”键，进入“会员详情”页面
            SelectMemberPageOpn.ClickConfirmBtn(_driver);

            // 在“会员详情”页面，获取充值之前的余额
            string beforeRechargeBalance = MembershipDetailsPageOpn.GetBalance(_driver);

            // 在“会员详情”页面，点击“充值”按钮
            MembershipDetailsPageOpn.ClickRechargeBtn(_driver);

            // 获取充值列表项，并选取第4个充值项（即充￥500赠优惠券[小吃券] X 1张）
            MemberRechargePageOpn.SelectRechargeItem(_driver, 3);

            // 点击“现金”充值按钮
            MemberRechargePageOpn.ClickCashRechargeBtn(_driver);

            // 点击“确定充值”键，进入“会员详情”页面
            MemberRechargePageOpn.ClickConfirmRechargeBtn(_driver);

            // 在“会员详情”页面，获取充值之后的余额
            string afterRechargeBalance = MembershipDetailsPageOpn.GetBalance(_driver);

            // 断言充值之后的金额是否是在充值之前的金额上增加了500元
            CustomAssertions.AssertEqual(float.Parse(beforeRechargeBalance) + float.Parse("500"), float.Parse(afterRechargeBalance), _driver);

            // 在“会员详情页”点击“优惠券”按钮
            MembershipDetailsPageOpn.ClickCouponBtn(_driver);

            // 在“优惠券”页面点击“不可用券”按钮
            CouponPageOpn.ClickUnavailableCouponBtn(_driver);

            // 创建字典，用于统计优惠券号码
            SortedDictionary<string, string> couponNumDict = new SortedDictionary<string, string>();

            // 统计“不可用优惠券”页面下，未生效优惠券的数量，用字典记录每一条优惠券号码，并返回该字典
            IList<SortedDictionary<string, string>> dictList = NotAvailableCouponPageScenario.GetUnavailableCouponList(_driver, couponNumDict);
            couponNumDict = dictList[0];

            // 连续点击两次“返回键”，回到“会员详情”页面
            _driver.PressKeyCode(4);
            _driver.PressKeyCode(4);

            // 在“会员详情”页面，点击“充值”按钮
            MembershipDetailsPageOpn.ClickRechargeBtn(_driver);

            // 获取充值列表项，并选取第4个充值项（即充￥500赠优惠券[小吃券] X 1张）
            MemberRechargePageOpn.SelectRechargeItem(_driver, 3);

            // 点击“现金”充值按钮
            MemberRechargePageOpn.ClickCashRechargeBtn(_driver);

            // 点击“确定充值”键，进入“会员详情”页面
            MemberRechargePageOpn.ClickConfirmRechargeBtn(_driver);

            // 在“会员详情页”点击“优惠券”按钮
            MembershipDetailsPageOpn.ClickCouponBtn(_driver);

            // 在“优惠券”页面点击“不可用券”按钮
            CouponPageOpn.ClickUnavailableCouponBtn(_driver);

            // 创建字典，用于统计新增的优惠券号码
            SortedDictionary<string, string> couponNumExtendDict = new SortedDictionary<string, string>();

            // 统计“不可用优惠券”页面下，未生效优惠券的数量，用字典记录每一条优惠券号码，并返回该字典
            dictList = NotAvailableCouponPageScenario.GetUnavailableCouponList(_driver, couponNumDict, couponNumExtendDict, false);
            couponNumExtendDict = dictList[1];

            // 判断优惠券是否被成功添加，如果“coupon_number_extend_dic”的长度等于1，则优惠券被成功添加
            CustomAssertions.AssertEqual(couponNumExtendDict.Count, 1, _driver);
        }
    }
}