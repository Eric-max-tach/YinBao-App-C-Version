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

    public class IndustrySelectionPageLocators
    {
        /*
         * 在登录页选择体验账号后，进入的行业选择页面元素定位器
         */
        // 零售行业按钮
        public static By RetailIndustryBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/retail_version_ll");

        // 餐饮行业按钮
        public static By CateringIndustryBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/food_version_ll");

        // 服装鞋帽按钮
        public static By ClothesShoesIndustryBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/clothing_version_ll");

        // 生活服务按钮
        public static By LifeServiceIndustryBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/service_version_ll");

        // 母婴行业按钮
        public static By BabyCareIndustryBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/maternal_supply_version_ll");

        // 宠物行业按钮
        public static By PetIndustryBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/pet_version_ll");

        // 烘焙行业按钮
        public static By BakingIndustryBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/bake_version_ll");

        // 生鲜称重行业按钮
        public static By FreshFoodIndustryBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/fresh_version_ll");

        // 美妆休闲行业按钮
        public static By LeisureBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/leisure_version_ll");

        // 敬请期待按钮
        public static By FutureBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/future_version_ll");
    }

    public class TryLoginPageLocators
    {
        /*
         * 体验账号登录页元素定位器
         */
        // 账号输入框
        public static By AccountInput => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/login_account_tv");

        // 工号输入框
        public static By JobNumberInput => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/account_tv");

        // 密码输入框
        public static By PasswordInput => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/password_tv");

        // 员工登录按钮
        public static By EmployeeLoginBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/login_btn");

        // 管理后台按钮
        public static By ManagerBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/manager_ll");

        // 联系客服按钮
        public static By ContactServiceBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/manager_ll");

        // 交接班记录按钮
        public static By HistoryHandoverBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/history_handover_ll");

        // Toast提示
        public static By Toast => By.XPath("//*[@class='android.widget.Toast']");
    }

    public class CashInterfacePageLocators
    {
        /*
         * 收银台页面元素定位器
         */
        // 未读消息按钮
        public static By UnreadMessageBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/notice_ib");

        // 获取Toast提示
        public static By Toast => By.XPath("//*[@class='android.widget.Toast']");

        // 分类集合列表
        public static By CategoryList => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/category_gv']/*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/root_rl']");

        // 获取具体分类的文本框
        public static By CategoryText => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/name_tv']");

        // 某一分类下商品集合
        public static By GoodsList => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/product_rv']/*[@class='android.widget.RelativeLayout']");

        // 某一分类下,某个商品的价格
        public static By GoodsPriceText => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/price_et']");

        // 某一分类下,某个商品的商品名
        public static By GoodsNameText => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/name_tv']");

        // “点击选择会员”按钮
        public static By SelectMemberBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/customer_rl");

        // “订单”视图框
        public static By OrderView => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/sale_ls");

        // 当前屏幕中订单视图框内所有商品的序号的元素集合
        public static By OrderViewGoodsNums => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/sale_ls']//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/no_tv']");

        // 当前屏幕中订单视图框内所有商品的名称的元素集合
        public static By OrderViewGoodsNames => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/sale_ls']//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/plu_name_tv']");

        // 当前屏幕中订单视图框内所有商品的单价的元素集合
        public static By OrderViewGoodsPrices => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/sale_ls']//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/price_tv']");

        // 当前屏幕中订单视图框内所有商品的折扣的元素集合
        public static By OrderViewGoodsDiscounts => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/sale_ls']//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/discount_tv']");

        // “收银”按钮
        public static By CashBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/checkout_action_ll");

        // “实收金额”文本值
        public static By ReceiptPriceText => By.Id("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/checkout_action_ll']/*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/amount_tv']");

        // “总额”文本值
        public static By TotalPriceText => By.Id("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/cart_rl']/*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/subtotal_tv']");

        // “折扣”文本值
        public static By DiscountText => By.Id("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/cart_rl']/*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/discount_tv']");

        // “优惠券”图标按钮
        public static By CouponBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/coupon_ll");
    }
}
