using appiumtest.bases;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                在输入账号密码后点击登录按钮
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

    public class IndustrySelectionPageOpn: BasePage
    {
        /*
         * 在登录页选择体验账号后，进入的行业选择页面的相关操作
         */
        // 实例化 NLog 日志对象
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");

        public static void ClickRetailIndustryBtn(AndroidDriver driver)
        {
            /*
                零售行业按钮点击
             */
            logger.Info("==========retail_industry_btn==========");
            IWebElement ele = get_exists_element(IndustrySelectionPageLocators.RetailIndustryBtn, driver);
            ele.Click();
        }

        public static void ClickFoodIndustryBtn(AndroidDriver driver)
        {
            /*
                餐饮行业按钮点击
             */
            logger.Info("==========food_industry_btn==========");
            IWebElement ele = get_exists_element(IndustrySelectionPageLocators.CateringIndustryBtn, driver);
            ele.Click();
        }

        public static void ClickClothesShoesIndustryBtn(AndroidDriver driver)
        {
            /*
                服装鞋包行业按钮点击
             */
            logger.Info("==========clothes_shoes_industry_btn==========");
            IWebElement ele = get_exists_element(IndustrySelectionPageLocators.ClothesShoesIndustryBtn, driver);
            ele.Click();
        }

        public static void ClickLifeServiceIndustryBtn(AndroidDriver driver)
        {
            /*
                生活服务行业按钮点击
             */
            logger.Info("==========life_service_industry_btn==========");
            IWebElement ele = get_exists_element(IndustrySelectionPageLocators.LifeServiceIndustryBtn, driver);
            ele.Click();
        }

        public static void ClickBabyCareIndustryBtn(AndroidDriver driver)
        {
            /*
                母婴行业按钮点击
             */
            logger.Info("==========baby_care_industry_btn==========");
            IWebElement ele = get_exists_element(IndustrySelectionPageLocators.BabyCareIndustryBtn, driver);
            ele.Click();
        }

        public static void ClickPetIndustryBtn(AndroidDriver driver)
        {
            /*
                宠物行业按钮点击
             */
            logger.Info("==========pet_industry_btn==========");
            IWebElement ele = get_exists_element(IndustrySelectionPageLocators.PetIndustryBtn, driver);
            ele.Click();
        }

        public static void BakingIndustryBtn(AndroidDriver driver)
        {
            /*
                烘焙行业按钮点击
             */
            logger.Info("==========baking_industry_btn==========");
            IWebElement ele = get_exists_element(IndustrySelectionPageLocators.BakingIndustryBtn, driver);
            ele.Click();
        }

        public static void ClickFreshFoodIndustryBtn(AndroidDriver driver)
        {
            /*
                生鲜行业按钮点击
             */
            logger.Info("==========fresh_food_industry_btn==========");
            IWebElement ele = get_exists_element(IndustrySelectionPageLocators.FreshFoodIndustryBtn, driver);
            ele.Click();
        }

        public static void ClickLeisureIndustyBtn(AndroidDriver driver)
        {
            /*
                休闲娱乐行业按钮点击
             */
            logger.Info("==========leisure_industry_btn==========");
            IWebElement ele = get_exists_element(IndustrySelectionPageLocators.LifeServiceIndustryBtn, driver);
            ele.Click();
        }

        public static void ClickFutureBtn(AndroidDriver driver)
        {
            /*
                敬请期待按钮点击
             */
            logger.Info("==========future_industry_btn==========");
            IWebElement ele = get_exists_element(IndustrySelectionPageLocators.FutureBtn, driver);
            ele.Click();
        }
    }

    public class TryLogInPageOpn: BasePage
    {
        /*
         * 体验账号登录页面的相关操作
         */
        // 实例化 NLog 日志对象
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");

        public static string GetAccountInputText(AndroidDriver driver)
        {
            /*
                获取账号输入框文本
             */
            logger.Info("==========get_account_input_text==========");
            IWebElement ele = get_exists_element(TryLoginPageLocators.AccountInput, driver);
            return ele.Text;
        }

        public static void InputJobNumber(string jobNumber, AndroidDriver driver)
        {
            /*
                工号输入框输入工号
             */
            logger.Info("==========input_job_number==========");
            IWebElement ele = get_exists_element(TryLoginPageLocators.JobNumberInput, driver);
            if (GetAccountInputText(driver).Length != 0)
            {
                ele.Clear();    // 如果工号输入框中有内容，则先清空内容
            }
            ele.SendKeys(jobNumber);
        }

        public static void InputPassword(string password, AndroidDriver driver)
        {
            /*
                密码输入框输入密码
             */
            logger.Info("==========input_password==========");
            IWebElement ele = get_exists_element(TryLoginPageLocators.PasswordInput, driver);
            ele.Clear();
            ele.SendKeys(password);
        }
        
        public static void ClickEmployeeLoginBtn(AndroidDriver driver)
        {
            /*
                员工登录按钮点击
             */
            logger.Info("==========employee_login_btn==========");
            IWebElement ele = get_exists_element(TryLoginPageLocators.EmployeeLoginBtn, driver);
            ele.Click();
        }

        public static void ClickManagerBtn(AndroidDriver driver)
        {
            /*
                管理后台按钮点击
             */
            logger.Info("==========manager_login_btn==========");
            IWebElement ele = get_exists_element(TryLoginPageLocators.ManagerBtn, driver);
            ele.Click();
        }

        public static void ClickContactServiceBtn(AndroidDriver driver)
        {
            /*
                联系客服按钮点击
             */
            logger.Info("==========contact_service_btn==========");
            IWebElement ele = get_exists_element(TryLoginPageLocators.ContactServiceBtn, driver);
            ele.Click();
        }

        public static void ClickHistoryHandoverBtn(AndroidDriver driver)
        {
            /*
                交接班记录按钮点击
             */
            logger.Info("==========history_handover_btn==========");
            IWebElement ele = get_exists_element(TryLoginPageLocators.HistoryHandoverBtn, driver);
            ele.Click();
        }

        public static string GetToastText(AndroidDriver driver)
        {
            /*
                获取Toast文本信息
             */
            logger.Info("==========get_toast_text==========");
            IWebElement ele = get_exists_element(TryLoginPageLocators.Toast, driver);
            return ele.Text;
        }
    }

    public class CashInterfacePageOpn : BasePage
    {
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");
        /*
         * 收银页面元素相关操作
         */
        public static void ClickUnreadMessageBtn(AndroidDriver driver)
        {
            /*
             * 点击未读消息按钮
             */
            logger.Info("==========unread_message_btn==========");
            IWebElement ele = get_exists_element(CashInterfacePageLocators.UnreadMessageBtn, driver);
            ele.Click();
        }

        // 点击指定序号的“分类”按钮，并获得其分类名：
        public static string ClickCategoryBtn(int index, AndroidDriver driver)
        {
            /*
             * 点击指定序号的“分类”按钮，并获得其分类名
             */
            logger.Info("==========category_btn==========");
            IList<IWebElement> eles = get_exists_elements(CashInterfacePageLocators.CategoryList, driver);
            IWebElement ele = eles[index];
            ele.Click();
            IWebElement categoryEle = get_exists_element(CashInterfacePageLocators.CategoryText, driver, ele);
            return categoryEle.Text;
        }

        // 点击某一分类下的“新增商品”按钮
        public static void ClickAddProductBtn(string categoryName, AndroidDriver driver)
        {
            /*
             * 点击某一分类下的“新增商品”按钮
             */
            logger.Info("==========add_product_btn==========");
            while (true)
            {
                IList<IWebElement> eles = get_exists_elements(CashInterfacePageLocators.GoodsList, driver);
                // 获取列表中最后一个元素的文本值是不是"新增商品",如果不是则一直向下滑动列表,直到找到该元素
                try
                {
                    get_visible_element_need_exception(CashInterfacePageLocators.CategoryText, driver, eles[eles.Count - 1], 1, 1);
                }
                catch (TimeoutException e)
                {
                    // 如果列表的最后一个元素不是“新增商品”，那么通过try模块中获取元素的方法在滑动屏幕到底部后就无法成功获取元素，这个是否就会报超时错误
                    IWebElement lastEle = eles[eles.Count - 1].FindElement(By.XPath("//*[@text='新增商品']"));
                    Console.WriteLine(lastEle.Text);
                    eles[eles.Count - 1].Click();
                    break;
                }
            }
        }

        // 获取指定分类序号下,最新添加的商品名和商品售价
        public static string[] GetNewestProductNameAndPrice(int categoryIndex, AndroidDriver driver)
        {
            /*
             * 获取指定分类序号下,最新添加的商品名和商品售价
             * （最新添加的商品位于对应分类列表中的倒数第二个元素）
             */
            logger.Info("==========get_newest_product_name_and_price==========");
            while (true)
            {
                IList<IWebElement> eles = get_exists_elements(CashInterfacePageLocators.GoodsList, driver);
                // 获取列表中最后一个元素的文本值是不是"新增商品",如果不是则一直向下滑动列表,直到找到该元素
                try
                {
                    get_visible_element_need_exception(CashInterfacePageLocators.CategoryText, driver, eles[eles.Count - 1], 1, 1);
                }
                catch (TimeoutException e)
                {
                    // 如果列表的最后一个元素不是“新增商品”，那么通过try模块中获取元素的方法在滑动屏幕到底部后就无法成功获取元素，这个是否就会报超时错误
                    IWebElement newTradeNameEle = get_exists_element(CashInterfacePageLocators.GoodsNameText, driver, eles[eles.Count - 2]);
                    IWebElement newTradePriceEle = get_exists_element(CashInterfacePageLocators.GoodsPriceText, driver, eles[eles.Count - 2]);
                    string[] result = { newTradeNameEle.Text, newTradePriceEle.Text };
                    return result;
                }

                // 滑动窗口到底部
                swipe_screen(0.5, 0.95, 0.5, 0.45, driver);

                // 清空列表
                eles.Clear();
            }
        }

        // 点击“点击选择会员”按钮
        public static void ClickChooseMemberBtn(AndroidDriver driver)
        {
            /*
             * 点击“点击选择会员”按钮
             */
            logger.Info("==========choose_member_btn==========");
            IWebElement ele = get_exists_element(CashInterfacePageLocators.SelectMemberBtn, driver);
            ele.Click();
        }

        // 获取当前分类下的商品列表中，显示在屏幕中的商品个数（不是该列表的所有商品）
        public static int GetGoodsCountOnScreen(AndroidDriver driver)
        {
            /*
             * 获取当前分类下的商品列表中，显示在屏幕中的商品个数（不是该列表的所有商品）
             */
            logger.Info("==========get_goods_count_on_screen==========");
            int count = 0;
            IList<IWebElement> eles = get_exists_elements(CashInterfacePageLocators.GoodsList, driver);
            count = eles.Count;
            return count;
        }

        // 点击指定序号的商品
        public static void ClickGoodsBtn(int index, AndroidDriver driver)
        {
            /*
             * 点击指定序号的商品
             */
            logger.Info("==========click_goods_btn==========");
            IList<IWebElement> eles = get_exists_elements(CashInterfacePageLocators.GoodsList, driver);
            eles[index].Click();
        }

        // 获取指定序号的商品名
        public static string GetGoodsName(int index, AndroidDriver driver)
        {
            /*
             * 获取指定序号的商品名
             */
            logger.Info("==========get_goods_name==========");
            IList<IWebElement> eles = get_exists_elements(CashInterfacePageLocators.GoodsList, driver);
            return get_exists_element(CashInterfacePageLocators.GoodsNameText, driver, eles[index]).Text;
        }

        // 获取指定序号的商品价格
        public static string GetGoodsPrice(int index, AndroidDriver driver)
        {
            /*
             * 获取指定序号的商品价格
             */
            logger.Info("==========get_goods_price==========");
            IList<IWebElement> eles = get_exists_elements(CashInterfacePageLocators.GoodsList, driver);
            return get_exists_element(CashInterfacePageLocators.GoodsPriceText, driver, eles[index]).Text;
        }

        // 获取“订单”视图框的大小，并返回该视图框左上角和右下角的坐标值，即"[480,92][1440,1080]"
        public static int[] GetOrderViewRect(AndroidDriver driver)
        {
            /*
             * 获取“订单”视图框的大小，并返回该视图框左上角和右下角的坐标值，即"[480,92][1440,1080]"
             */
            logger.Info("==========get_order_view_rect==========");
            IWebElement ele = get_exists_element(CashInterfacePageLocators.OrderView, driver);

            // 获取元素的 'bounds' 属性
            string eleBounds = ele.GetDomAttribute("bounds");

            // 使用正则表达式提取坐标对
            var matches = Regex.Matches(eleBounds, @"\[(\d+),(\d+)\]");

            // 提取两个坐标对
            int topLeftX = int.Parse(matches[0].Groups[1].Value);
            int topLeftY = int.Parse(matches[0].Groups[2].Value);
            int lowerRightX = int.Parse(matches[1].Groups[1].Value);
            int lowerRightY = int.Parse(matches[1].Groups[2].Value);

            // 返回坐标对
            int[] result = { topLeftX, topLeftY, lowerRightX, lowerRightY };
            return result;
        }

        // 获取当前屏幕中订单视图框内所有商品的序号的元素集合
        public static IList<IWebElement> GetOrderViewGoodsIndexEles(AndroidDriver driver)
        {
            /*
             * 获取当前屏幕中订单视图框内所有商品的序号的元素集合
             */
            logger.Info("==========get_order_view_goods_index_eles==========");
            IList<IWebElement> eles = get_exists_elements(CashInterfacePageLocators.OrderViewGoodsNums, driver);
            return eles;
        }

        // 将订单列表滑动到顶部
        public static void ScrollOrderViewToTop(AndroidDriver driver)
        {
            /*
             * 将订单列表滑动到顶部
             */
            logger.Info("==========scroll_order_view_to_top==========");
            // 获取“订单”视图框列表的大小，得到视图框左上角和右下角的坐标值，即"[480,92][1440,1080]"
            int[] rect = GetOrderViewRect(driver);
            int topLeftX = rect[0];
            int topLeftY = rect[1];
            int lowerRightX = rect[2];
            int lowerRightY = rect[3];

            // 获取屏幕的大小
            int screenWidth = driver.Manage().Window.Size.Width;
            int screenHeight = driver.Manage().Window.Size.Height;

            // 将订单滑动到顶部
            while (true)
            {
                // 获取当前屏幕中订单视图框内所有商品的序号的元素
                IList<IWebElement> productIdsInOrderEles = GetOrderViewGoodsIndexEles(driver);

                // 判断当前屏幕中的订单位置,第一个商品的序号是否为"01.",如果为1则说明已经滑动到顶部
                if (productIdsInOrderEles[0].Text.Equals("01."))
                {
                    break;
                }
                else
                {
                    // 如果当前屏幕中的订单位置不是顶部,则滑动屏幕
                    swipe_screen(((lowerRightX + topLeftX) * 0.5) / screenWidth,
                        (topLeftY * 1.1) / screenHeight,
                        ((lowerRightX + topLeftX) * 0.5) / screenWidth,
                        (lowerRightY * 0.9) / screenHeight,
                        driver);
                }
            }
        }

        // 将订单列表滑动到底部，并统计订单中包含的商品名和商品价格，返回两个字典，分别为订单中的商品名和商品价格
        public static Dictionary<string, string>[] ScrollOrderViewToBottomAndGetOrderInfo(AndroidDriver driver, Dictionary<string, string> productNamesInOrder, Dictionary<string, string> productPricesInOrder)
        {
            /*
             * 将订单列表滑动到底部，并统计订单中包含的商品名和商品价格，返回两个字典，分别为订单中的商品名和商品价格
             */
            logger.Info("==========scroll_order_view_to_bottom_and_get_order_info==========");
            // 获取“订单”视图框列表的大小，得到视图框左上角和右下角的坐标值，即"[480,92][1440,1080]"
            int[] rect = GetOrderViewRect(driver);
            int topLeftX = rect[0];
            int topLeftY = rect[1];
            int lowerRightX = rect[2];
            int lowerRightY = rect[3];

            // 获取屏幕的大小
            int screenWidth = driver.Manage().Window.Size.Width;
            int screenHeight = driver.Manage().Window.Size.Height;

            // 判断是否已经滑动到列表底部的标志位
            string lastIdInOrder = "0";

            while (true)
            {
                // 获取当前屏幕中订单视图框内所有商品的序号的元素集合
                IList<IWebElement> productIdsInOrderEles = get_exists_elements(CashInterfacePageLocators.OrderViewGoodsNums, driver);

                // 获得当前屏幕中订单视图框内所有商品的名称和价格元素集合
                IList<IWebElement> productNamesInOrderEles = get_exists_elements(CashInterfacePageLocators.OrderViewGoodsNames, driver);
                IList<IWebElement> productPricesInOrderEles = get_exists_elements(CashInterfacePageLocators.OrderViewGoodsPrices, driver);

                /*
                 * 可能会出现当前屏幕中订单视图框中最后一个元素"商品序号","商品名字","商品价格"不能同时获取的情况
                 * 当上述情况发生时,就先不处理最后一个元素
                */
                int minLen = Math.Min(Math.Min(productIdsInOrderEles.Count, productNamesInOrderEles.Count), productPricesInOrderEles.Count);

                for (int i = 0; i < minLen; i++)
                {
                    string productId = productIdsInOrderEles[i].Text;   // 商品在订单中的编号
                    if (!productNamesInOrder.ContainsKey(productId))
                    {
                        productNamesInOrder.Add(productId, productNamesInOrderEles[i].Text);   // 商品名称
                    }
                    if (!productPricesInOrder.ContainsKey(productId))
                    {
                        productPricesInOrder.Add(productId, productPricesInOrderEles[i].Text.Split('￥')[^1]);   // 商品价格
                    }
                }

                if (productIdsInOrderEles[minLen - 1].Text.Equals(lastIdInOrder))   // 用于判断是否滑动到列表底部
                {
                    break;
                }

                lastIdInOrder = productIdsInOrderEles[minLen - 1].Text;   // 更新上一个商品的序号

                // 滑动"订单列表"
                swipe_screen(((lowerRightX + topLeftX) * 0.5) / screenWidth,
                    (lowerRightY * 0.9) / screenHeight,
                    ((lowerRightX + topLeftX) * 0.5) / screenWidth,
                    (lowerRightY * 0.5) / screenHeight,
                    driver);

                // 清空列表
                productIdsInOrderEles.Clear();
                productNamesInOrderEles.Clear();
                productPricesInOrderEles.Clear();
            }
            Dictionary<string, string>[] result = { productNamesInOrder, productPricesInOrder };
            return result;
        }

        // 统计在订单中的商品的折扣值列表
        public static Dictionary<string, string> GetOrderDiscountList(AndroidDriver driver, Dictionary<string, string> productDiscountInOrderDict)
        {
            /*
             * 统计在订单中的商品的折扣值列表
             */
            logger.Info("==========get_order_discount_list==========");
            // 获取“订单”视图框列表的大小，得到视图框左上角和右下角的坐标值，即"[480,92][1440,1080]"
            int[] rect = GetOrderViewRect(driver);
            int topLeftX = rect[0];
            int topLeftY = rect[1];
            int lowerRightX = rect[2];
            int lowerRightY = rect[3];

            // 获取屏幕的大小
            int screenWidth = driver.Manage().Window.Size.Width;
            int screenHeight = driver.Manage().Window.Size.Height;

            // 判断是否已经滑动到列表底部的标志位
            string lastIdInOrder = "0";

            while (true)
            {
                // 获取当前屏幕中订单视图框内所有商品的序号的元素集合
                IList<IWebElement> productIdsInOrderEles = get_exists_elements(CashInterfacePageLocators.OrderViewGoodsNums, driver);

                // 获取当前屏幕中订单视图框内所有商品的折扣的元素集合
                IList<IWebElement> productDiscountsInOrderEles = get_exists_elements(CashInterfacePageLocators.OrderViewGoodsDiscounts, driver);

                /*
                 * 可能会出现当前屏幕中订单视图框中最后一个元素"商品序号","商品名字","商品价格","商品折扣"不能同时获取的情况
                 * 当上述情况发生时,就先不处理最后一个元素
                */
                int minLen = Math.Min(productIdsInOrderEles.Count, productDiscountsInOrderEles.Count);

                for (int i = 0; i < minLen; i++) // 遍历订单视图框内所有商品的序号元素,并将其添加到列表中
                {
                    string productId = productIdsInOrderEles[i].Text;   // 商品在订单中的编号
                    if (!productDiscountInOrderDict.ContainsKey(productId))
                    {
                        productDiscountInOrderDict.Add(productId, productDiscountsInOrderEles[i].Text);   // 商品折扣
                    }
                }  

                if (productIdsInOrderEles[minLen - 1].Text.Equals(lastIdInOrder))   // 用于判断是否滑动到列表底部
                {
                    break;
                }

                lastIdInOrder = productIdsInOrderEles[minLen - 1].Text;   // 更新上一个商品的序号

                // 滑动"订单列表"
                swipe_screen(((lowerRightX + topLeftX) * 0.5) / screenWidth,
                    (lowerRightY * 0.9) / screenHeight,
                    ((lowerRightX + topLeftX) * 0.5) / screenWidth,
                    (lowerRightY * 0.5) / screenHeight,
                    driver);

                // 清空列表
                productIdsInOrderEles.Clear();
                productDiscountsInOrderEles.Clear();
            }
            return productDiscountInOrderDict;
        }

        // 点击“收银”按钮
        public static void ClickCashBtn(AndroidDriver driver)
        {
            /*
             * 点击“收银”按钮
             */
            logger.Info("==========cash_btn==========");
            IWebElement ele = get_exists_element(CashInterfacePageLocators.CashBtn, driver);
            ele.Click();
        }

        // 获取“实收金额”文本值
        public static string GetActualAmountText(AndroidDriver driver)
        {
            /*
             * 获取“实收金额”文本值
             */
            logger.Info("==========actual_amount_text==========");
            IWebElement ele = get_exists_element(CashInterfacePageLocators.ReceiptPriceText, driver);
            return ele.Text.Substring(1);    // 去掉第一个字符 "￥"
        }

        // 获取“总金额”文本值
        public static string GetTotalAmountText(AndroidDriver driver)
        {
            /*
             * 获取“总金额”文本值
             */
            logger.Info("==========total_amount_text==========");
            IWebElement ele = get_exists_element(CashInterfacePageLocators.TotalPriceText, driver);
            return ele.Text.Substring(2);  // 去掉前缀 "总额" (2 个字符)
        }

        // 获取“折扣金额”文本值
        public static string GetDiscountAmountText(AndroidDriver driver)
        {
            /*
             * 获取“折扣金额”文本值
             */
            logger.Info("==========discount_amount_text==========");
            IWebElement ele = get_exists_element(CashInterfacePageLocators.DiscountText, driver);
            return ele.Text.Substring(2);  // 去掉前缀 "折扣" (2 个字符)
        }

        // 点击订单栏下方“优惠券”图标按钮
        public static void ClickCouponBtn(AndroidDriver driver)
        {
            /*
             * 点击订单栏下方“优惠券”图标按钮
             */
            logger.Info("==========coupon_btn==========");
            IWebElement ele = get_exists_element(CashInterfacePageLocators.CouponBtn, driver);
            ele.Click();
        }
    }
}
