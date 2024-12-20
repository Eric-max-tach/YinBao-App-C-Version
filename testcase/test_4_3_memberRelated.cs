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
    public class TestLogin_4_3 : StartEnd
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

            // 点击“自用品（收银用）”分类按钮
            string categoryName = CashInterfacePageOpn.ClickCategoryBtn(3, _driver);

            // 从当前屏幕所显示的菜品中随机选择两个菜品
            List<string> productNameList = new List<string>();
            List<string> productPriceList = new List<string>();
            int actualProductCount = Math.Min(19, CashInterfacePageOpn.GetGoodsCountOnScreen(_driver)); // 除去"新增商品"按钮,一页最多获取到19个商品信息
            Random random = new Random();   // 随机生成一组不重复的商品序号
            HashSet<int> uniqueNumbersHashSet = new HashSet<int>();
            while(uniqueNumbersHashSet.Count < (actualProductCount / 2))
            {
                uniqueNumbersHashSet.Add(random.Next(0, actualProductCount));
            }
            List<int> uniqueNumbers = uniqueNumbersHashSet.ToList();

            for (int i = 0; i < uniqueNumbers.Count; i++)
            {
                // 点击指定序号的商品
                CashInterfacePageOpn.ClickGoodsBtn(uniqueNumbers[i], _driver);

                // 获取指定序号的商品名
                productNameList.Add(CashInterfacePageOpn.GetGoodsName(uniqueNumbers[i], _driver));

                // 获取指定序号的商品价格
                productPriceList.Add(CashInterfacePageOpn.GetGoodsPrice(uniqueNumbers[i], _driver));
            }
            
            // 将订单列表滑动到顶部
            CashInterfacePageOpn.ScrollOrderViewToTop(_driver);

            // 将订单列表滑动到底部，并统计订单中包含的商品名和商品价格，返回两个字典，分别为订单中的商品名和商品价格
            // 统计在订单中的商品名和商品价格
            SortedDictionary<string, string> productNameInOrderSortedDictionary = new SortedDictionary<string, string>();
            SortedDictionary<string, string> productPriceInOrderSortedDictionary = new SortedDictionary<string, string>();
            SortedDictionary<string, string>[] orderInfo = CashInterfacePageOpn.ScrollOrderViewToBottomAndGetOrderInfo(_driver, productNameInOrderSortedDictionary, productPriceInOrderSortedDictionary);
            
            // 判断记录订单中商品的名字和价格与从菜单中选取的商品的名字和价格是否相等
            List<string> productNameInOrderList = orderInfo[0].Values.ToList();
            List<string> productPriceInOrderList = orderInfo[1].Values.ToList();
            // 先判断订单中商品数量是否等于菜单中选取的商品数量
            CustomAssertions.AssertEqual(productNameInOrderList.Count, productNameList.Count, _driver);
            CustomAssertions.AssertEqual(productPriceInOrderList.Count, productPriceList.Count, _driver);
            // 再判断订单中商品名和价格是否与菜单中选取的商品名和价格相等
            for (int i = 0; i < productNameList.Count; i++)
            {
                CustomAssertions.AssertEqual(productNameInOrderList[i], productNameList[i], _driver);
                CustomAssertions.AssertEqual(productPriceInOrderList[i], productPriceList[i], _driver);
            }

            // 在收银页面，点击“收银”按钮
            CashInterfacePageOpn.ClickCashBtn(_driver);

            // 在结账详情页，点击“储蓄卡”按钮
            RechargeDetailPageOpn.ClickStoredCardBtn(_driver);

            // 在选择会员页面,输入键盘数字"5"，并点击"确定"按钮
            SelectMemberPageOpn.InputNumber5(_driver);
            SelectMemberPageOpn.ClickConfirmBtn(_driver);

            // 在会员详情页，获取扣款前的会员余额
            string beforeDeductionBalance = MembershipDetailsPageOpn.GetBalance(_driver);

            // 在会员详情页，点击“选择会员”按钮
            MembershipDetailsPageOpn.ClickSelectMemberBtn(_driver);

            // 在结账详情页，获取实际的实收金额
            string actualReceivedAmount = RechargeDetailPageOpn.GetActualAmount(_driver);

            // 在结账详情页，点击“确定”按钮，确认付款
            RechargeDetailPageOpn.ClickConfirmBtn(_driver);

            // 在收银页面，判断左侧的订单栏是否为空
            /*
             * 判断逻辑：获取订单列表中第一个商品的序号的元素，如果在指定时间内没有找到该元素，会抛出超时异常，则说明订单被成功清空
             */
            try
            {
                BasePage.get_visible_element_need_exception(CashInterfacePageLocators.OrderViewGoodsNums, _driver, null, 1, 0);
            }
            catch (Exception e)
            {
                // 判断捕获的异常是否是超时异常（即订单被成功清空）
                CustomAssertions.AssertTrue((e is NoSuchElementException), _driver);
            }

            // 在收银页面,点击"点击选择会员"按钮
            CashInterfacePageOpn.ClickChooseMemberBtn(_driver);

            // 在选择会员页面,输入键盘数字"5"，并点击"确定"按钮
            SelectMemberPageOpn.InputNumber5(_driver);
            SelectMemberPageOpn.ClickConfirmBtn(_driver);

            // 在会员详情页，获取扣款后的会员余额
            string afterDeductionBalance = MembershipDetailsPageOpn.GetBalance(_driver);

            // 判断扣款是否正确
            CustomAssertions.AssertEqual((int)(float.Parse(afterDeductionBalance) + float.Parse(actualReceivedAmount)), (int)(float.Parse(beforeDeductionBalance)), _driver);
        }
    }
}
