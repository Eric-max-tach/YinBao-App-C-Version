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
        public static void ClickAddProductBtn(AndroidDriver driver)
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
                catch (NoSuchElementException e)
                {
                    // 如果列表的最后一个元素不是“新增商品”，那么通过try模块中获取元素的方法在滑动屏幕到底部后就无法成功获取元素，这个是否就会报超时错误
                    IWebElement lastEle = eles[eles.Count - 1].FindElement(By.XPath("//*[@text='新增商品']"));
                    Console.WriteLine(lastEle.Text);
                    eles[eles.Count - 1].Click();
                    break;
                }

                // 滑动屏幕，从屏幕的（0.5， 0.95）的位置滑动到屏幕的（0.5， 0.4）的位置，持续时间1s
                swipe_screen(0.5, 0.95, 0.5, 0.4, driver);

                //// 清空列表
                //eles.Clear();
            }
        }

        // 获取指定分类序号下,最新添加的商品名和商品售价
        public static string[] GetNewestProductNameAndPrice(AndroidDriver driver)
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
                catch (NoSuchElementException e)
                {
                    // 如果列表的最后一个元素不是“新增商品”，那么通过try模块中获取元素的方法在滑动屏幕到底部后就无法成功获取元素，这个是否就会报超时错误
                    IWebElement newTradeNameEle = get_exists_element(CashInterfacePageLocators.GoodsNameText, driver, eles[eles.Count - 2]);
                    IWebElement newTradePriceEle = get_exists_element(CashInterfacePageLocators.GoodsPriceText, driver, eles[eles.Count - 2]);
                    string[] result = { newTradeNameEle.Text, newTradePriceEle.Text };
                    return result;
                }

                // 滑动窗口到底部
                swipe_screen(0.5, 0.95, 0.5, 0.4, driver);

                //// 清空列表
                //eles.Clear();
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
            return get_exists_element(CashInterfacePageLocators.GoodsPriceText, driver, eles[index]).Text.Split('￥')[^1];
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
        public static SortedDictionary<string, string>[] ScrollOrderViewToBottomAndGetOrderInfo(AndroidDriver driver, SortedDictionary<string, string> productNamesInOrder, SortedDictionary<string, string> productPricesInOrder)
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

                //// 清空列表
                //productIdsInOrderEles.Clear();
                //productNamesInOrderEles.Clear();
                //productPricesInOrderEles.Clear();
            }
            SortedDictionary<string, string>[] result = { productNamesInOrder, productPricesInOrder };
            return result;
        }

        // 统计在订单中的商品的折扣值列表
        public static SortedDictionary<string, string> GetOrderDiscountList(AndroidDriver driver, SortedDictionary<string, string> productDiscountInOrderDict)
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

        // 点击“菜单”图标按钮
        public static void ClickMenuBtn(AndroidDriver driver)
        {
            /*
             * 点击“菜单”图标按钮
             */
            logger.Info("==========menu_btn==========");
            IWebElement ele = get_exists_element(CashInterfacePageLocators.MenuBtn, driver);
            ele.Click();
        }
    }

    public class SelectCouponInterfaceOpn : BasePage
    {
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");
        /*
         * 在收银页面的订单栏下方点击“优惠券”图标按钮后进入的选择优惠券页面元素的操作
         */
        // 点击“普通优惠券”按钮
        public static void ClickNormalCouponBtn(AndroidDriver driver)
        {
            /*
             * 点击“普通优惠券”按钮
             */
            logger.Info("==========normal_coupon_btn==========");
            IWebElement ele = get_exists_element(SelectCouponInterfaceLocators.CommonCouponBtn, driver);
            ele.Click();
        }

        // 点击“通用券码”按钮
        public static void ClickGeneralCouponBtn(AndroidDriver driver)
        {
            /*
             * 点击“通用券码”按钮
             */
            logger.Info("==========general_coupon_btn==========");
            IWebElement ele = get_exists_element(SelectCouponInterfaceLocators.CommonCouponCodeBtn, driver);
            ele.Click();
        }

        // 点击“券扫码下单”按钮
        public static void ClickCouponScanOrderBtn(AndroidDriver driver)
        {
            /*
             * 点击“券扫码下单”按钮
             */
            logger.Info("==========coupon_scan_order_btn==========");
            IWebElement ele = get_exists_element(SelectCouponInterfaceLocators.ScanCodeBtn, driver);
            ele.Click();
        }

        // 获得“优惠券列表”视图框大小，并返回其左上角和右下角的坐标值
        public static int[] GetCouponListViewRect(AndroidDriver driver)
        {
            /*
             * 获得“优惠券列表”视图框大小，并返回其左上角和右下角的坐标值
             */
            logger.Info("==========get_coupon_list_view_rect==========");
            IWebElement ele = get_exists_element(SelectCouponInterfaceLocators.CouponListView, driver);

            // 获取元素的 'bounds' 属性
            string eleBounds = ele.GetDomAttribute("bounds");

            // 使用正则表达式提取坐标对
            var matches = Regex.Matches(eleBounds, @"\[(\d+),(\d+)\]");

            // 提取两个坐标对
            int topLeftX = int.Parse(matches[0].Groups[1].Value);
            int topLeftY = int.Parse(matches[0].Groups[2].Value);
            int lowerRightX = int.Parse(matches[1].Groups[1].Value);
            int lowerRightY = int.Parse(matches[1].Groups[2].Value);

            return new int[] { topLeftX, topLeftY, lowerRightX, lowerRightY };
        }

        // 点击指定序号的“优惠券列表”中优惠券的“添加”按钮
        public static void ClickCouponAddBtnByIndex(AndroidDriver driver, int index)
        {
            /*
             * 点击指定序号的“优惠券列表”中优惠券的“添加”按钮
             * 
             * :param index: 显示在当前屏幕中的优惠券的序号（从1开始）
             */
            logger.Info("==========click_coupon_add_btn_by_index==========");
            IList<IWebElement> couponAddBtnEles = get_exists_elements(SelectCouponInterfaceLocators.AddCouponBtns, driver);
            couponAddBtnEles[index - 1].Click();
        }

        // 点击指定序号的“优惠券列表”中优惠券的“删除”按钮
        public static void ClickCouponDeleteBtnByIndex(AndroidDriver driver, int index)
        {
            /*
             * 点击指定序号的“优惠券列表”中优惠券的“删除”按钮
             * 
             * :param index: 显示在当前屏幕中的优惠券的序号（从1开始）
             */
            logger.Info("==========click_coupon_delete_btn_by_index==========");
            IList<IWebElement> couponDeleteBtnEles = get_exists_elements(SelectCouponInterfaceLocators.DeleteCouponBtns, driver);
            couponDeleteBtnEles[index - 1].Click();
        }

        // 查找并点击指定次数和名称的优惠券
        public static void ClickCouponByTimesAndName(AndroidDriver driver, string coupon_prefix_name, int coupon_num, bool is_add)
        {
            /*
             * 查找并点击指定次数和名称的优惠券
             * 
             * :param str coupon_prefix_name: 所要查找的优惠券的名称的前缀
             * :param int coupon_num:  优惠券添加/删除个数
             * :param bool is_add:  判断是添加还是删除优惠券，True为添加优惠券，False为删除优惠券
             */
            logger.Info("==========click_coupon_by_times_and_name==========");

            // 获得“优惠券列表”视图框列表的大小，得到视图框左上角和右下角的坐标值，即"[480,92][1440,1080]"
            int[] rect = GetCouponListViewRect(driver);
            int topLeftX = rect[0];
            int topLeftY = rect[1];
            int lowerRightX = rect[2];
            int lowerRightY = rect[3];

            // 判断是否已经滑动到列表底部的标志位
            string lastCouponName = ".";

            // 获取屏幕的大小
            int screenWidth = driver.Manage().Window.Size.Width;
            int screenHeight = driver.Manage().Window.Size.Height;

            while (true)
            {
                // 获取当前屏幕中优惠券列表视图框内所有优惠券的名称的元素集合
                IList<IWebElement> couponNamesInListViewEles = get_exists_elements(SelectCouponInterfaceLocators.CouponNameText, driver);

                // 获取当前屏幕中优惠券列表视图框内所有优惠券的添加按钮的元素集合
                IList<IWebElement> couponAddBtnsInListViewEles = get_exists_elements(SelectCouponInterfaceLocators.AddCouponBtns, driver);

                // 获取当前屏幕中优惠券列表视图框内所有优惠券的删除按钮的元素集合
                IList<IWebElement> couponDeleteBtnsInListViewEles = get_exists_elements(SelectCouponInterfaceLocators.DeleteCouponBtns, driver);

                // 判断当前优惠券列表视图中，是否有名称为“20减5”的优惠券
                int lens = Math.Min(couponNamesInListViewEles.Count, couponAddBtnsInListViewEles.Count);    // 有可能存在列表最后一个元素没有加载出来的情况
                for (int i = 0; i < lens; i++) // 遍历优惠券列表视图框内所有优惠券的名称元素,并将其添加到列表中
                {
                    string couponName = couponNamesInListViewEles[i].Text;   // 优惠券名称
                    if (couponName.StartsWith(coupon_prefix_name))
                    {
                        if (is_add) // 添加优惠券
                        {
                            for (int j = 0; j < coupon_num; j++)
                            {
                                couponAddBtnsInListViewEles[i].Click();
                            }
                        }
                        else  // 删除优惠券
                        {
                            for (int j = 0; j < coupon_num; j++)
                            {
                                couponDeleteBtnsInListViewEles[i].Click();
                            }
                        }
                    }
                }

                if (couponNamesInListViewEles[lens - 1].Text.Equals(lastCouponName))   // 用于判断是否滑动到列表底部
                {
                    break;
                }

                lastCouponName = couponNamesInListViewEles[lens - 1].Text;   // 更新上一个优惠券的名称

                // 滑动"优惠券列表"
                swipe_screen(((lowerRightX + topLeftX) * 0.5) / screenWidth,
                    (lowerRightY * 0.9) / screenHeight,
                    ((lowerRightX + topLeftX) * 0.5) / screenWidth,
                    (lowerRightY * 0.5) / screenHeight,
                    driver);

                // 清空列表
                couponNamesInListViewEles.Clear();
                couponAddBtnsInListViewEles.Clear();
                couponDeleteBtnsInListViewEles.Clear();
            }
        }

        // 点击“确定”按钮
        public static void ClickConfirmBtn(AndroidDriver driver)
        {
            /*
             * 点击“确定”按钮
             */
            logger.Info("==========confirm_btn==========");
            IWebElement ele = get_exists_element(SelectCouponInterfaceLocators.ConfirmBtn, driver);
            ele.Click();
        }
    }

    public class NewProductPageOpn: BasePage
    {
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");
        /*
         * 新建商品页面元素的操作
         */
        // 在“新增商品”页面，点击“生成”按钮，生成随机条码
        public static void ClickGenerateBarcodeBtn(AndroidDriver driver)
        {
            /*
             * 在“新增商品”页面，点击“生成”按钮，生成随机条码
             */
            logger.Info("==========click_generate_barcode_btn==========");
            IWebElement ele = get_exists_element(NewProductPageLocators.GenerateBarcodeBtn, driver);
            ele.Click();
        }

        // 获取商品条码文本框的文本值
        public static string GetBarcodeInputText(AndroidDriver driver)
        {
            /*
             * 获取商品条码文本框的文本值
             */
            logger.Info("==========get_barcode_input_ele==========");
            return get_exists_element(NewProductPageLocators.BarcodeInput, driver).Text;
        }

        // 在“品名”输入框，输入商品名
        public static void InputProductName(AndroidDriver driver, string productName)
        {
            /*
             * 在“品名”输入框，输入商品名
             * 
             * :param str productName: 商品名
             */
            logger.Info("==========input_product_name==========");
            IWebElement ele = get_exists_element(NewProductPageLocators.ProductNameInput, driver);
            ele.Clear();
            ele.SendKeys(productName);
        }

        // 在“库存”输入框，输入库存
        public static void InputProductStock(AndroidDriver driver, string productStock)
        {
            /*
             * 在“库存”输入框，输入库存
             * 
             * :param str productStock: 商品库存
             */
            logger.Info("==========input_product_stock==========");
            IWebElement ele = get_exists_element(NewProductPageLocators.StockInput, driver);
            ele.Clear();
            ele.SendKeys(productStock);
        }

        // 在“售价”输入框，输入售价
        public static void InputProductPrice(AndroidDriver driver, string productPrice)
        {
            /*
             * 在“售价”输入框，输入售价
             * 
             * :param str productPrice: 商品售价
             */
            logger.Info("==========input_product_price==========");
            IWebElement ele = get_exists_element(NewProductPageLocators.PriceInput, driver);
            ele.Clear();
            ele.SendKeys(productPrice);
        }

        // 在“进价”输入框，输入进价
        public static void InputProductCost(AndroidDriver driver, string productCost)
        {
            /*
             * 在“进价”输入框，输入进价
             * 
             * :param str productCost: 商品进价
             */
            logger.Info("==========input_product_cost==========");
            IWebElement ele = get_exists_element(NewProductPageLocators.PurchasePriceInput, driver);
            ele.Clear();
            ele.SendKeys(productCost);
        }

        // 点击“保存”按钮,保存新增商品
        public static void ClickSaveBtn(AndroidDriver driver)
        {
            /*
             * 点击“保存”按钮,保存新增商品
             */
            logger.Info("==========click_save_btn==========");
            IWebElement ele = get_exists_element(NewProductPageLocators.SaveBtn, driver);
            ele.Click();
        }

        // 点击“分类”按钮，弹出分类下拉框
        public static void ClickCategoryBtn(AndroidDriver driver)
        {
            /*
             * 点击“分类”按钮，弹出分类下拉框
             */
            logger.Info("==========click_category_btn==========");
            IWebElement ele = get_exists_element(NewProductPageLocators.CategorySelect, driver);
            ele.Click();
        }

        // 在“分类”下拉框中，点击搜索栏并输入搜索内容
        public static void InputCategorySearch(AndroidDriver driver, string searchContent)
        {
            /*
             * 在“分类”下拉框中，点击搜索栏并输入搜索内容
             * 
             * :param str searchContent: 搜索内容
             */
            logger.Info("==========input_category_search==========");
            IWebElement ele = get_exists_element(NewProductPageLocators.CategorySearchInput, driver);
            ele.Clear();
            ele.SendKeys(searchContent);
        }

        // 在“分类”下拉框中，点击搜索结果集合中第一条搜索结果
        public static void ClickCategoryFirstResult(AndroidDriver driver)
        {
            /*
             * 在“分类”下拉框中，点击搜索结果集合中第一条搜索结果
             */
            logger.Info("==========click_category_first_result==========");
            IWebElement ele = get_exists_element(NewProductPageLocators.CategorySearchResult, driver);
            ele.Click();
        }

        // 在“分类”下拉框中，点击“保存”按钮
        public static void ClickCategorySaveBtn(AndroidDriver driver)
        {
            /*
             * 在“分类”下拉框中，点击“保存”按钮
             */
            logger.Info("==========click_category_save_btn==========");
            IWebElement ele = get_exists_element(NewProductPageLocators.CategoryConfirmBtn, driver);
            ele.Click();
        }
    }

    public class MessageCenterPageOpn : BasePage
    {
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");
        /*
         * 消息中心页面元素的操作
         */
        // 点击“库存预警”按钮
        public static void ClickStockWarningBtn(AndroidDriver driver)
        {
            /*
             * 点击“库存预警”按钮
             */
            logger.Info("==========click_stock_warning_btn==========");
            IWebElement ele = get_exists_element(MessageCenterPageLocators.StockWarningBtn, driver);
            ele.Click();
        }

        // 获得“库存预警”版块的待处理通知的数量
        public static int GetStockWarningCount(AndroidDriver driver)
        {
            /*
             * 获得“库存预警”版块的待处理通知的数量
             */
            logger.Info("==========get_stock_warning_count==========");
            IWebElement ele = get_exists_element(MessageCenterPageLocators.StockWarningNum, driver);
            return int.Parse(ele.Text);
        }

        // 点击“全选”按钮
        public static void ClickSelectAllBtn(AndroidDriver driver)
        {
            /*
             * 点击“全选”按钮
             */
            logger.Info("==========click_select_all_btn==========");
            IWebElement ele = get_exists_element(MessageCenterPageLocators.SelectAllBtn, driver);
            ele.Click();
        }

        // 点击“忽略此商品”按钮
        public static void ClickIgnoreBtn(AndroidDriver driver)
        {
            /*
             * 点击“忽略此商品”按钮
             */
            logger.Info("==========click_ignore_btn==========");
            IWebElement ele = get_exists_element(MessageCenterPageLocators.IgnoreThisGoodsBtn, driver);
            ele.Click();
        }

        // 点击“返回”按钮
        public static void ClickBackBtn(AndroidDriver driver)
        {
            /*
             * 点击“返回”按钮
             */
            logger.Info("==========click_back_btn==========");
            IWebElement ele = get_exists_element(MessageCenterPageLocators.BackBtn, driver);
            ele.Click();
        }
    }

    public class SelectMemberPageOpn: BasePage
    {
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");
        /*
         * 会员选择页面元素的操作
         */
        // 在搜索框输入数字“1”
        public static void InputNumber1(AndroidDriver driver)
        { 
            /*
             * 在搜索框输入数字“1”
             */
            logger.Info("==========input_number_1==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.Number1Btn, driver);
            ele.Click();
        }

        // 在搜索框输入数字“2”
        public static void InputNumber2(AndroidDriver driver)
        {
            /*
             * 在搜索框输入数字“2”
             */
            logger.Info("==========input_number_2==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.Number2Btn, driver);
            ele.Click();
        }

        // 在搜索框输入数字“3”
        public static void InputNumber3(AndroidDriver driver)
        {
            /*
             * 在搜索框输入数字“3”
             */
            logger.Info("==========input_number_3==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.Number3Btn, driver);
            ele.Click();
        }

        // 在搜索框输入数字“4”
        public static void InputNumber4(AndroidDriver driver)
        {
            /*
             * 在搜索框输入数字“4”
             */
            logger.Info("==========input_number_4==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.Number4Btn, driver);
            ele.Click();
        }

        // 在搜索框输入数字“5”
        public static void InputNumber5(AndroidDriver driver)
        {
            /*
             * 在搜索框输入数字“5”
             */
            logger.Info("==========input_number_5==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.Number5Btn, driver);
            ele.Click();
        }

        // 在搜索框输入数字“6”
        public static void InputNumber6(AndroidDriver driver)
        {
            /*
             * 在搜索框输入数字“6”
             */
            logger.Info("==========input_number_6==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.Number6Btn, driver);
            ele.Click();
        }

        // 在搜索框输入数字“7”
        public static void InputNumber7(AndroidDriver driver)
        {
            /*
             * 在搜索框输入数字“7”
             */
            logger.Info("==========input_number_7==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.Number7Btn, driver);
            ele.Click();
        }

        // 在搜索框输入数字“8”
        public static void InputNumber8(AndroidDriver driver)
        {
            /*
             * 在搜索框输入数字“8”
             */
            logger.Info("==========input_number_8==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.Number8Btn, driver);
            ele.Click();
        }

        // 在搜索框输入数字“9”
        public static void InputNumber9(AndroidDriver driver)
        {
            /*
             * 在搜索框输入数字“9”
             */
            logger.Info("==========input_number_9==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.Number9Btn, driver);
            ele.Click();
        }

        // 在搜索框输入数字“0”
        public static void InputNumber0(AndroidDriver driver)
        {
            /*
             * 在搜索框输入数字“0”
             */
            logger.Info("==========input_number_0==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.Number0Btn, driver);
            ele.Click();
        }

        // 在搜索框输入数字“00”
        public static void InputNumber00(AndroidDriver driver)
        {
            /*
             * 在搜索框输入数字“00”
             */
            logger.Info("==========input_number_00==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.Number00Btn, driver);
            ele.Click();
        }

        // 在搜索框输入数字"."
        public static void InputDot(AndroidDriver driver)
        {
            /*
             * 在搜索框输入数字"."
             */
            logger.Info("==========input_dot==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.DotBtn, driver);
            ele.Click();
        }

        // 点击“删除”按钮
        public static void ClickDeleteBtn(AndroidDriver driver)
        {
            /*
             * 点击“删除”按钮
             */
            logger.Info("==========click_delete_btn==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.DeleteBtn, driver);
            ele.Click();
        }

        // 点击“确定”按钮
        public static void ClickConfirmBtn(AndroidDriver driver)
        {
            /*
             * 点击“确定”按钮
             */
            logger.Info("==========click_confirm_btn==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.ConfirmBtn, driver);
            ele.Click();
        }

        // 点击“添加会员”按钮
        public static void ClickAddMemberBtn(AndroidDriver driver)
        {
            /*
             * 点击“添加会员”按钮
             */
            logger.Info("==========click_add_member_btn==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.AddMemberBtn, driver);
            ele.Click();
        }

        // 点击“扫描”按钮
        public static void ClickScanBtn(AndroidDriver driver)
        {
            /*
             * 点击“扫描”按钮
             */
            logger.Info("==========click_scan_btn==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.ScanBtn, driver);
            ele.Click();
        }

        // 点击“返回”按钮
        public static void ClickBackBtn(AndroidDriver driver)
        {
            /*
             * 点击“返回”按钮
             */
            logger.Info("==========click_back_btn==========");
            IWebElement ele = get_exists_element(SelectMemberPageLocators.BackBtn, driver);
            ele.Click();
        }
    }

    public class MembershipDetailsPageOpn: BasePage
    {
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");
        /*
         * 会员详情页面元素的操作
         */
        // 点击“充值”按钮
        public static void ClickRechargeBtn(AndroidDriver driver)
        {
            /*
             * 点击“充值”按钮
             */
            logger.Info("==========click_recharge_btn==========");
            IWebElement ele = get_exists_element(MembershipDetailsPageLocators.RechargeBtn, driver);
            ele.Click();
        }

        // 点击“选择会员”按钮
        public static void ClickSelectMemberBtn(AndroidDriver driver)
        {
            /*
             * 点击“选择会员”按钮
             */
            logger.Info("==========click_select_member_btn==========");
            IWebElement ele = get_exists_element(MembershipDetailsPageLocators.SelectMemberBtn, driver);
            ele.Click();
        }

        // 获取“余额”
        public static string GetBalance(AndroidDriver driver)
        {
            /*
             * 获取“余额”
             */
            logger.Info("==========get_balance==========");
            IWebElement ele = get_exists_element(MembershipDetailsPageLocators.BalanceText, driver);
            return ele.Text;
        }

        // 点击“优惠券查看”按钮
        public static void ClickCouponBtn(AndroidDriver driver)
        {
            /*
             * 点击“优惠券查看”按钮
             */
            logger.Info("==========click_coupon_btn==========");
            IWebElement ele = get_exists_element(MembershipDetailsPageLocators.CouponViewBtn, driver);
            ele.Click();
        }

        // 获取“积分”
        public static string GetIntegral(AndroidDriver driver)
        {
            /*
             * 获取“积分”
             */
            logger.Info("==========get_integral==========");
            IWebElement ele = get_exists_element(MembershipDetailsPageLocators.IntegralText, driver);
            return ele.Text;
        }

        // 点击“积分兑换”按钮
        public static void ClickIntegralBtn(AndroidDriver driver)
        {
            /*
             * 点击“积分兑换”按钮
             */
            logger.Info("==========click_integral_btn==========");
            IWebElement ele = get_exists_element(MembershipDetailsPageLocators.IntegralExchangeBtn, driver);
            ele.Click();
        }
    }

    public class MemberRechargePageOpn: BasePage
    {
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");
        /*
         * 会员充值页面元素的操作
         */
        // 选择指定充值项
        public static void SelectRechargeItem(AndroidDriver driver, int itemNo)
        {
            /*
             * 选择指定充值项
             * 
             * :param int itemNo: 充值项序号（从0开始）
             */
            logger.Info("==========select_recharge_item==========");
            IList<IWebElement> eles = get_exists_elements(MemberRechargePageLocators.RechargeItemList, driver);
            eles[itemNo].Click();
        }

        // 点击“现金”充值按钮
        public static void ClickCashRechargeBtn(AndroidDriver driver)
        {
            /*
             * 点击“现金”充值按钮
             */
            logger.Info("==========click_cash_recharge_btn==========");
            IWebElement ele = get_exists_element(MemberRechargePageLocators.CashRechargeBtn, driver);
            ele.Click();
        }

        // 点击“银联卡”充值按钮
        public static void ClickUnionPayRechargeBtn(AndroidDriver driver)
        {
            /*
             * 点击“银联卡”充值按钮
             */
            logger.Info("==========click_union_pay_recharge_btn==========");
            IWebElement ele = get_exists_element(MemberRechargePageLocators.UnionPayRechargeBtn, driver);
            ele.Click();
        }

        // 点击“收款码”充值按钮
        public static void ClickQrcodeRechargeBtn(AndroidDriver driver)
        {
            /*
             * 点击“收款码”充值按钮
             */
            logger.Info("==========click_qrcode_recharge_btn==========");
            IWebElement ele = get_exists_element(MemberRechargePageLocators.QRCodeRechargeBtn, driver);
            ele.Click();
        }

        // 点击“支付宝”充值按钮
        public static void ClickAlipayRechargeBtn(AndroidDriver driver)
        {
            /*
             * 点击“支付宝”充值按钮
             */
            logger.Info("==========click_alipay_recharge_btn==========");
            IWebElement ele = get_exists_element(MemberRechargePageLocators.AlipayRechargeBtn, driver);
            ele.Click();
        }

        // 点击“微信”充值按钮
        public static void ClickWechatRechargeBtn(AndroidDriver driver)
        {
            /*
             * 点击“微信”充值按钮
             */
            logger.Info("==========click_wechat_recharge_btn==========");
            IWebElement ele = get_exists_element(MemberRechargePageLocators.WechatRechargeBtn, driver);
            ele.Click();
        }

        // 点击“三福支付”充值按钮
        public static void ClickThreeFubaoRechargeBtn(AndroidDriver driver)
        {
            /*
             * 点击“三福支付”充值按钮
             */
            logger.Info("==========click_three_fubao_recharge_btn==========");
            IWebElement ele = get_exists_element(MemberRechargePageLocators.ThreeFubaoRechargeBtn, driver);
            ele.Click();
        }

        // 点击“确认充值”按钮
        public static void ClickConfirmRechargeBtn(AndroidDriver driver)
        {
            /*
             * 点击“确认充值”按钮
             */
            logger.Info("==========click_confirm_recharge_btn==========");
            IWebElement ele = get_exists_element(MemberRechargePageLocators.ConfirmRechargeBtn, driver);
            ele.Click();
        }

        // 获取“充值成功后打印小票”选择框的状态，通过checked属性进行判断
        public static bool GetPrintTicketStatus(AndroidDriver driver)
        {
            /*
             * 获取“充值成功后打印小票”选择框的状态，通过checked属性进行判断
             */
            logger.Info("==========get_print_ticket_status==========");
            IWebElement ele = get_exists_element(MemberRechargePageLocators.PrintTicketSelect, driver);
            return ele.GetDomAttribute("checked") == "true";
        }

        // 点击“充值成功后打印小票”选择框
        public static void ClickPrintTicketSelect(AndroidDriver driver)
        {
            /*
             * 点击“充值成功后打印小票”选择框
             */
            logger.Info("==========click_print_ticket_select==========");
            IWebElement ele = get_exists_element(MemberRechargePageLocators.PrintTicketSelect, driver);
            ele.Click();
        }
    }

    public class CouponPageOpn: BasePage
    {
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");
        /*
         * 优惠券页面元素的操作
         */
        // 点击“不可用券”按钮
        public static void ClickUnavailableCouponBtn(AndroidDriver driver) 
        {
            /*
             * 点击“不可用券”按钮
             */
            logger.Info("==========click_unavailable_coupon_btn==========");
            IWebElement ele = get_exists_element(CouponPageLocators.UnavailableCouponBtn, driver);
            ele.Click();
        }
    }

    public class NotAvailableCouponPageOpn: BasePage
    { 
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");
        /*
         * 不可用优惠券页面元素的操作
         */
        // 获取“未生效优惠券”视图框列表的大小，并返回视图框左上角和右下角的坐标值
        public static int[] GetUnavailableCouponViewBox(AndroidDriver driver)
        {
            /*
             * 获取“未生效优惠券”视图框列表的大小，并返回视图框左上角和右下角的坐标值
             */
            logger.Info("==========get_unavailable_coupon_view_box==========");
            IWebElement ele = get_exists_element(NotAvailableCouponPageLocators.UnavailableCouponListView, driver);

            // 获取元素的 'bounds' 属性
            string eleBounds = ele.GetDomAttribute("bounds");

            // 使用正则表达式提取坐标对
            var matches = Regex.Matches(eleBounds, @"\[(\d+),(\d+)\]");

            // 提取两个坐标对
            int topLeftX = int.Parse(matches[0].Groups[1].Value);
            int topLeftY = int.Parse(matches[0].Groups[2].Value);
            int lowerRightX = int.Parse(matches[1].Groups[1].Value);
            int lowerRightY = int.Parse(matches[1].Groups[2].Value);

            return new int[] { topLeftX, topLeftY, lowerRightX, lowerRightY };
        }

        // 获取当前显示在“未生效优惠券”视图框中，优惠券号码元素列表
        public static IList<IWebElement> GetUnavailableCouponList(AndroidDriver driver)
        {
            /*
             * 获取当前显示在“未生效优惠券”视图框中，优惠券号码元素列表
             */
            logger.Info("==========get_unavailable_coupon_list==========");
            IList<IWebElement> eles = get_exists_elements(NotAvailableCouponPageLocators.UnavailableCouponNum, driver);
            return eles;
        }
    }

    public class PointExchangePageOpn: BasePage
    {
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");
        /*
         * 积分兑换页面元素的操作
         */
        // 获取“积分兑换商品”列表元素
        public static IList<IWebElement> GetPointExchangeList(AndroidDriver driver)
        {
            /*
             * 获取“积分兑换商品”列表元素
             */
            logger.Info("==========get_point_exchange_list==========");
            IList<IWebElement> eles = get_exists_elements(PointExchangePageLocators.PointsExchangeViewElem, driver);
            return eles;
        }

        // 点击“积分兑换商品”列表中，指定序号的元素
        public static void ClickPointExchangeItem(AndroidDriver driver, int itemNo)
        {
            /*
             * 点击“积分兑换商品”列表中，指定序号的元素
             * 
             * :param int itemNo: 元素序号（从0开始）
             */
            logger.Info("==========click_point_exchange_item==========");
            IList<IWebElement> eles = get_exists_elements(PointExchangePageLocators.PointsExchangeViewElem, driver);
            if (itemNo == -1)
            {
                itemNo = eles.Count - 1;
            }
            if (itemNo >= eles.Count)
            {
                throw new Exception("元素序号超出范围");
            }


            eles[itemNo].Click();
        }

        // 获取“积分兑换商品”列表中，指定序号元素的积分值
        public static string GetPointExchangeItemIntegral(AndroidDriver driver, int itemNo)
        {
            /*
             * 获取“积分兑换商品”列表中，指定序号元素的积分值
             * 
             * :param int itemNo: 元素序号（从0开始）
             */
            logger.Info("==========get_point_exchange_item_integral==========");
            IList<IWebElement> eles = GetPointExchangeList(driver);
            if (itemNo == -1)
            {
                itemNo = eles.Count - 1;
            }
            if (itemNo >= eles.Count)
            {
                throw new Exception("元素序号超出范围");
            }

            IWebElement ele = get_exists_element(PointExchangePageLocators.PointsExchangeItemPoints, driver, eles[itemNo]);
            return ele.Text;
        }

        // 获取"积分兑换商品"列表中,指定序号元素的品名
        public static string GetPointExchangeItemTitle(AndroidDriver driver, int itemNo)
        {
            /*
             * 获取"积分兑换商品"列表中,指定序号元素的品名
             * 
             * :param int itemNo: 元素序号（从0开始）
             */
            logger.Info("==========get_point_exchange_item_title==========");
            IList<IWebElement> eles = GetPointExchangeList(driver);
            if (itemNo == -1)
            {
                itemNo = eles.Count - 1;
            }
            if (itemNo >= eles.Count)
            {
                throw new Exception("元素序号超出范围");
            }

            IWebElement ele = get_exists_element(PointExchangePageLocators.PointsExchangeItemName, driver, eles[itemNo]);
            return ele.Text;
        }

        // 点击“积分兑换”按钮
        public static void ClickPointExchangeBtn(AndroidDriver driver)
        {
            /*
             * 点击“积分兑换”按钮
             */
            logger.Info("==========click_point_exchange_btn==========");
            IWebElement ele = get_exists_element(PointExchangePageLocators.ExchangeBtn, driver);
            ele.Click();
        }

        // 获取“积分兑换商品”视图大小，并返回视图框左上角和右下角的坐标值
        public static int[] GetPointExchangeViewBox(AndroidDriver driver)
        {
            /*
             * 获取“积分兑换商品”视图大小，并返回视图框左上角和右下角的坐标值
             */
            logger.Info("==========get_point_exchange_view_box==========");
            IWebElement ele = get_exists_element(PointExchangePageLocators.PointsExchangeViewElem, driver);

            // 获取元素的 'bounds' 属性
            string eleBounds = ele.GetDomAttribute("bounds");

            // 使用正则表达式提取坐标对
            var matches = Regex.Matches(eleBounds, @"\[(\d+),(\d+)\]");

            // 提取两个坐标对
            int topLeftX = int.Parse(matches[0].Groups[1].Value);
            int topLeftY = int.Parse(matches[0].Groups[2].Value);
            int lowerRightX = int.Parse(matches[1].Groups[1].Value);
            int lowerRightY = int.Parse(matches[1].Groups[2].Value);

            return new int[] { topLeftX, topLeftY, lowerRightX, lowerRightY };
        }

        // 搜索框发送指定数据
        public static void SendSearchData(AndroidDriver driver, string data)
        {
            /*
             * 搜索框发送指定数据
             * 
             * :param string data: 要发送的数据
             */
            logger.Info("==========send_search_data==========");
            IWebElement ele = get_exists_element(PointExchangePageLocators.SearchInput, driver);
            ele.SendKeys(data);
        }
    }

    public class RechargeDetailPageOpn: BasePage
    {
        public static NLog.Logger logger = LogManager.GetLogger("Mylogger");
        /*
         * 结账详情页相关元素操作
         */
        // 点击"现金"按钮
        public static void ClickCashBtn(AndroidDriver driver)
        {
            /*
             * 点击"现金"按钮
             */
            logger.Info("==========click_cash_btn==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.CashBtn, driver);
            ele.Click();
        }

        // 点击"储值卡"按钮
        public static void ClickStoredCardBtn(AndroidDriver driver)
        {
            /*
             * 点击"储值卡"按钮
             */
            logger.Info("==========click_stored_card_btn==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.StoredCardBtn, driver);
            ele.Click();
        }

        // 点击"银联卡"按钮
        public static void ClickUnionPayBtn(AndroidDriver driver)
        {
            /*
             * 点击"银联卡"按钮
             */
            logger.Info("==========click_union_pay_btn==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.UnionPayBtn, driver);
            ele.Click();
        }

        // 点击"收款码"按钮
        public static void ClickQrcodeBtn(AndroidDriver driver)
        {
            /*
             * 点击"收款码"按钮
             */
            logger.Info("==========click_qrcode_btn==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.QRCodeBtn, driver);
            ele.Click();
        }

        // 点击"Zfb支付"按钮
        public static void ClickZfbBtn(AndroidDriver driver)
        {
            /*
             * 点击"Zfb支付"按钮
             */
            logger.Info("==========click_zfb_btn==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.AlipayBtn, driver);
            ele.Click();
        }

        // 点击"预付卡"按钮
        public static void ClickPrepaidCardBtn(AndroidDriver driver)
        {
            /*
             * 点击"预付卡"按钮
             */
            logger.Info("==========click_prepaid_card_btn==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.PrepaidCardBtn, driver);
            ele.Click();
        }

        // 输入数字“1”
        public static void InputNum1(AndroidDriver driver)
        {
            /*
             * 输入数字“1”
             */
            logger.Info("==========input_num_1==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.Number1Btn, driver);
            ele.Click();
        }

        // 输入数字“2”
        public static void InputNum2(AndroidDriver driver)
        {
            /*
             * 输入数字“2”
             */
            logger.Info("==========input_num_2==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.Number2Btn, driver);
            ele.Click();
        }

        // 输入数字“3”
        public static void InputNum3(AndroidDriver driver)
        {
            /*
             * 输入数字“3”
             */
            logger.Info("==========input_num_3==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.Number3Btn, driver);
            ele.Click();
        }

        // 输入数字“4”
        public static void InputNum4(AndroidDriver driver)
        {
            /*
             * 输入数字“4”
             */
            logger.Info("==========input_num_4==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.Number4Btn, driver);
            ele.Click();
        }

        // 输入数字“5”
        public static void InputNum5(AndroidDriver driver)
        {
            /*
             * 输入数字“5”
             */
            logger.Info("==========input_num_5==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.Number5Btn, driver);
            ele.Click();
        }

        // 输入数字“6”
        public static void InputNum6(AndroidDriver driver)
        {
            /*
             * 输入数字“6”
             */
            logger.Info("==========input_num_6==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.Number6Btn, driver);
            ele.Click();
        }

        // 输入数字“7”
        public static void InputNum7(AndroidDriver driver)
        {
            /*
             * 输入数字“7”
             */
            logger.Info("==========input_num_7==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.Number7Btn, driver);
            ele.Click();
        }

        // 输入数字“8”
        public static void InputNum8(AndroidDriver driver)
        {
            /*
             * 输入数字“8”
             */
            logger.Info("==========input_num_8==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.Number8Btn, driver);
            ele.Click();
        }

        // 输入数字“9”
        public static void InputNum9(AndroidDriver driver)
        {
            /*
             * 输入数字“9”
             */
            logger.Info("==========input_num_9==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.Number9Btn, driver);
            ele.Click();
        }

        // 输入数字“0”
        public static void InputNum0(AndroidDriver driver)
        {
            /*
             * 输入数字“0”
             */
            logger.Info("==========input_num_0==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.Number0Btn, driver);
            ele.Click();
        }

        // 输入数字“00”
        public static void InputNum00(AndroidDriver driver)
        {
            /*
             * 输入数字“00”
             */
            logger.Info("==========input_num_00==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.Number00Btn, driver);
            ele.Click();
        }

        // 输入数字"."
        public static void InputDot(AndroidDriver driver)
        {
            /*
             * 输入数字"."
             */
            logger.Info("==========input_dot==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.DotBtn, driver);
            ele.Click();
        }

        // 点击"删除"按钮
        public static void ClickDeleteBtn(AndroidDriver driver)
        {
            /*
             * 点击"删除"按钮
             */
            logger.Info("==========click_delete_btn==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.DeleteBtn, driver);
            ele.Click();
        }

        //  点击"确定"按钮
        public static void ClickConfirmBtn(AndroidDriver driver)
        {
            /*
             * 点击"确定"按钮
             */
            logger.Info("==========click_confirm_btn==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.ConfirmBtn, driver);
            ele.Click();
        }

        // 获取“应收金额”文本信息
        public static string GetReceivableAmount(AndroidDriver driver)
        {
            /*
             * 获取“应收金额”文本信息
             */
            logger.Info("==========get_receivable_amount==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.ReceivableAmountText, driver);
            return ele.Text;
        }

        // 获取“实收金额”文本信息
        public static string GetActualAmount(AndroidDriver driver)
        {
            /*
             * 获取“实收金额”文本信息
             */
            logger.Info("==========get_actual_amount==========");
            IWebElement ele = get_exists_element(RechargeDetailPageLocators.ActualAmountText, driver);
            return ele.Text;
        }
    }
}
