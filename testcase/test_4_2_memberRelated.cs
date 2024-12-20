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
    public class TestLogin_4_2: StartEnd
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

            // 在收银页面，点击“点击选择会员”按钮
            CashInterfacePageOpn.ClickChooseMemberBtn(_driver);

            // 在会员选择页面，获取会员搜索框，并发送值“1”
            SelectMemberPageOpn.InputNumber1(_driver);

            // 在会员选择页面，点击“确定”按钮，进入“会员详情”页面
            SelectMemberPageOpn.ClickConfirmBtn(_driver);

            // 在会员详情页面，获取未兑换商品之前的积分值
            float before_integral = float.Parse(MembershipDetailsPageOpn.GetIntegral(_driver));

            // 在会员详情页面，点击“兑换”按钮
            MembershipDetailsPageOpn.ClickIntegralBtn(_driver);

            List<float> integrals = new List<float>(); // 记录所消耗的积分值

            for (int i = 0; i < 2; i++)
            {
                // 在积分兑换页面，获取“积分兑换商品”列表中，指定序号元素的积分值
                float needed_point = float.Parse(PointExchangePageOpn.GetPointExchangeItemIntegral(_driver, i + 1));

                // 在积分兑换页面，记录当前兑换商品所需要的积分值
                integrals.Add(needed_point);

                // 在积分兑换页面，点击“积分兑换商品”列表中，指定序号的元素
                PointExchangePageOpn.ClickPointExchangeItem(_driver, i);
            }

            // 在积分兑换页面，点击“兑换”按钮
            PointExchangePageOpn.ClickPointExchangeBtn(_driver);

            // 在会员详情页面，获取兑换商品之后的积分值
            float after_integral = float.Parse(MembershipDetailsPageOpn.GetIntegral(_driver));

            // 判断积分值是否正确减少
            CustomAssertions.AssertEqual(before_integral - integrals.Sum(), after_integral, _driver);

            // 在会员详情页面，点击“兑换”按钮
            MembershipDetailsPageOpn.ClickIntegralBtn(_driver);

            // 在积分兑换页面，滑动列表，直到滑动到屏幕底部
            string last_item_name = PointExchangePageScenarios.GetLastItemName(_driver);

            // 在积分兑换页面，在搜索框输入获取到的最后一个元素
            PointExchangePageOpn.SendSearchData(_driver, last_item_name);

            // 在积分兑换页面，获取搜索结果中第一项元素以及对应的积分值
            IList<IWebElement> searchResultElems = PointExchangePageOpn.GetPointExchangeList(_driver);

            integrals.Clear(); // 记录所消耗的积分值

            for (int i = 0; i < searchResultElems.Count; i++)
            {
                // 在积分兑换页面，获取“积分兑换商品”列表中，指定序号元素的积分值
                float needed_point = float.Parse(PointExchangePageOpn.GetPointExchangeItemIntegral(_driver, i));

                // 在积分兑换页面，记录当前兑换商品所需要的积分值
                integrals.Add(needed_point);

                // 在积分兑换页面，点击“积分兑换商品”列表中，指定序号的元素
                PointExchangePageOpn.ClickPointExchangeItem(_driver, i);
            }

            // 在积分兑换页面，点击“兑换”按钮
            PointExchangePageOpn.ClickPointExchangeBtn(_driver);

            // 在会员详情页面，获取兑换商品之后的积分值
            float after_integral2 = float.Parse(MembershipDetailsPageOpn.GetIntegral(_driver));

            // 判断积分值是否正确减少
            CustomAssertions.AssertEqual(after_integral - integrals.Sum(), after_integral2, _driver);

        }
    }
}