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
        public static By ReceiptPriceText => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/checkout_action_ll']/*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/amount_tv']");

        // “总额”文本值
        public static By TotalPriceText => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/cart_rl']/*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/subtotal_tv']");

        // “折扣”文本值
        public static By DiscountText => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/cart_rl']/*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/discount_tv']");

        // “优惠券”图标按钮
        public static By CouponBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/coupon_ll");

        // “菜单”图标按钮
        public static By MenuBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/menu_ib");
    }

    public class SelectCouponInterfaceLocators
    {
        /*
         * 在收银页面的订单栏下方点击“优惠券”图标按钮后进入的选择优惠券页面元素定位
         */
        // “普通优惠券”按钮
        public static By CommonCouponBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/general_coupon_rb");

        // “通用券码”按钮
        public static By CommonCouponCodeBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/comment_coupon_rb");

        //“券扫码下单”按钮
        public static By ScanCodeBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/scanning_code_order_rb");

        // “优惠券列表”视图框
        public static By CouponListView => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/coupons_recycle_view");

        // “优惠券列表”中优惠券的“添加”按钮集合
        public static By AddCouponBtns => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/add_iv");

        // “优惠券列表”中优惠券的“删除”按钮集合
        public static By DeleteCouponBtns => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/sub_iv");

        // “优惠券列表”中优惠券的“已添加优惠券数量”文本值集合
        public static By CouponAddedNumText => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/qty_tv");

        // “优惠券列表”中优惠券的“名称”文本值集合
        public static By CouponNameText => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/coupon_name_tv");

        // “确定”按钮
        public static By ConfirmBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/ok_btn");
    }

    public class NewProductPageLocators
    {
        /*
         * 新增商品页面元素定位器
         */
        // “生成”按钮，生成随机条码
        public static By GenerateBarcodeBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/generate_barcode");

        // 商品条码文本框
        public static By BarcodeInput => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/number_et");

        // “品名”文本框
        public static By ProductNameInput => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/name_et");

        // “库存”文本框
        public static By StockInput => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/stock_et");

        // “售价”文本框
        public static By PriceInput => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/price_et");

        // “进价”文本框
        public static By PurchasePriceInput => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/buy_price_et");

        // “保存”按钮
        public static By SaveBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/save_ll");

        // “分类”下拉框
        public static By CategorySelect => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/category_tv");

        // “分类”下拉框中的搜索框
        public static By CategorySearchInput => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/input_et");

        // “分类”下拉框中的搜索结果
        public static By CategorySearchResult => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/ctg_rv']/*[@class='android.widget.LinearLayout']");

        // “分类”下拉框中的确定按钮
        public static By CategoryConfirmBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/ok_btn");
    }

    public class MessageCenterPageLocators
    {
        /*
         * 消息中心页面元素定位器
         */
        // 库存预警按钮
        public static By StockWarningBtn => By.XPath("//*[@text='库存预警']");

        // 库存预警的数量
        public static By StockWarningNum => By.XPath("//*[@text='库存预警']/following-sibling::*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/count_tv']");

        // 全选按钮
        public static By SelectAllBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/select_all_iv");

        // 忽略此商品按钮
        public static By IgnoreThisGoodsBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/left_btn");

        // 返回按钮
        public static By BackBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/back_tv");
    }

    public class SelectMemberPageLocators
    {
        /*
         * 选择会员页面元素定位器
         */
        // 搜索框“输入卡号/手机/姓名搜索会员”
        public static By SearchInput => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/input_et");

        // 数字“1”
        public static By Number1Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_1");

        // 数字“2”
        public static By Number2Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_2");

        // 数字“3”
        public static By Number3Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_3");

        // 数字“4”
        public static By Number4Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_4");

        // 数字“5”
        public static By Number5Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_5");

        // 数字“6”
        public static By Number6Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_6");

        // 数字“7”
        public static By Number7Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_7");

        // 数字“8”
        public static By Number8Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_8");

        // 数字“9”
        public static By Number9Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_9");

        // 数字“0”
        public static By Number0Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_0");

        // 数字“00”
        public static By Number00Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_00");

        // 数字“.”
        public static By DotBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_dot");

        // “删除”按钮
        public static By DeleteBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_del");

        // “确定”按钮
        public static By ConfirmBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/ok_btn");

        // “添加会员”按钮
        public static By AddMemberBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/add_btn");

        // “扫描”按钮
        public static By ScanBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/scan_mode_ib");

        // “返回”按钮
        public static By BackBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/back_tv");
    }

    public class MembershipDetailsPageLocators
    {
        /*
         * 会员详情页面元素定位器
         */
        // “充值”按钮
        public static By RechargeBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/recharge_btn");

        // “选择会员”按钮
        public static By SelectMemberBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/choose_btn");

        // “余额”文本值
        public static By BalanceText => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/balance_tv");

        // “积分”文本值
        public static By IntegralText => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/point_tv");

        // “优惠券查看”按钮
        public static By CouponViewBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/coupon_check_btn");

        // “积分兑换”按钮
        public static By IntegralExchangeBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/exchange_btn");
    }

    public class MemberRechargePageLocators
    {
        /*
         * 会员充值页面元素定位器
         */
        // 充值项列表
        public static By RechargeItemList => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/pass_product_list']/*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/root_rl']");

        // “现金”充值按钮
        public static By CashRechargeBtn => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/name_tv' and @text='现金']");

        // “银联卡”充值按钮
        public static By UnionPayRechargeBtn => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/name_tv' and @text='银联卡']");

        // “收款码”充值按钮
        public static By QRCodeRechargeBtn => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/name_tv' and @text='收款码']");

        //  “支付宝”充值按钮
        public static By AlipayRechargeBtn => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/name_tv' and @text='Zfb支付']");

        // “微信”充值按钮
        public static By WechatRechargeBtn => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/name_tv' and @text='微信']");

        // “三福”充值按钮
        public static By ThreeFubaoRechargeBtn => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/name_tv' and @text='三福支付']");

        // “确认充值”按钮
        public static By ConfirmRechargeBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/ok_btn");

        // “充值成功后打印小票”选择框
        public static By PrintTicketSelect => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/checkbox_ll']/*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/checkbox']");
    }

    public class CouponPageLocators
    {
        /*
         * 优惠券页面元素定位器
         */
        // “不可用券”按钮
        public static By UnavailableCouponBtn => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/action_1_tv' and @text='不可用券']");

        // “优惠券”列表视图
        public static By CouponListView => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/customer_coupon_rv']");
    }

    public class NotAvailableCouponPageLocators
    {
        /*
         * 不可用优惠券页面元素定位器
         */
        // “未生效优惠券”视图框
        public static By UnavailableCouponListView => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/invalid_customer_coupon_rv");

        // “已过期优惠券”视图框
        public static By ExpiredCouponListView => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/expired_customer_coupon_rv']");

        // “未生效优惠券”的优惠券编号
        public static By UnavailableCouponNum => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/invalid_customer_coupon_rv']//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/coupon_code_tv']");

        // “未生效优惠券”的优惠券名称
        public static By UnavailableCouponName => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/invalid_customer_coupon_rv']//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/coupon_name_tv']");

        // “已过期优惠券”的优惠券编号
        public static By ExpiredCouponNum => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/expired_customer_coupon_rv']//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/coupon_code_tv']");

        // “已过期优惠券”的优惠券名称
        public static By ExpiredCouponName => By.XPath("//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/expired_customer_coupon_rv']//*[@resource-id='cn.pospal.www.pospal_pos_android_new.pospal:id/coupon_name_tv']");
    }

    public class PointExchangePageLocators
    {
        /*
         * 积分兑换页面元素定位器
         */
        // “积分兑换商品”视图列表元素项
        public static By PointsExchangeViewElem => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/root_ll");

        // “积分兑换商品”列表中商品项的积分值
        public static By PointsExchangeItemPoints => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/need_point_tv");

        // "积分兑换商品"列表中商品项的品名
        public static By PointsExchangeItemName => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/product_name_tv");

        // “兑换”按钮
        public static By ExchangeBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/ok_btn");

        // “积分兑换商品”视图
        public static By PointExchangeGoodsView => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/product_list");

        // 搜索框
        public static By SearchInput => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/input_et");
    }

    public class RechargeDetailPageLocators
    {
        /*
         * 充值详情页面元素定位器
         */
        // "现金"按钮
        public static By CashBtn => By.XPath("//*[@text='现金']");

        // "储值卡"按钮
        public static By StoredCardBtn => By.XPath("//*[@text='储值卡']");

        // "银联卡"按钮
        public static By UnionPayBtn => By.XPath("//*[@text='银联卡']");

        // "收款码"按钮
        public static By QRCodeBtn => By.XPath("//*[@text='收款码']");

        // "Zfb支付"按钮
        public static By AlipayBtn => By.XPath("//*[@text='Zfb支付']");

        // "预付卡"按钮
        public static By PrepaidCardBtn => By.XPath("//*[@text='预付卡']");

        // 数字“1”
        public static By Number1Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_1");

        // 数字“2”
        public static By Number2Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_2");

        // 数字“3”
        public static By Number3Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_3");

        // 数字“4”
        public static By Number4Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_4");

        // 数字“5”
        public static By Number5Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_5");

        // 数字“6”
        public static By Number6Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_6");

        // 数字“7”
        public static By Number7Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_7");

        // 数字“8”
        public static By Number8Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_8");

        // 数字“9”
        public static By Number9Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_9");

        // 数字“0”
        public static By Number0Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_0");

        // 数字“00”
        public static By Number00Btn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_00");

        // 数字“.”
        public static By DotBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_dot");

        // “删除”按钮
        public static By DeleteBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/num_del");

        // “确定”按钮
        public static By ConfirmBtn => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/ok_btn");

        // “应收金额”文本信息
        public static By ReceivableAmountText => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/after_amount_tv");

        // “实收金额”文本信息
        public static By ActualAmountText => By.Id("cn.pospal.www.pospal_pos_android_new.pospal:id/real_take_et");
    }
}