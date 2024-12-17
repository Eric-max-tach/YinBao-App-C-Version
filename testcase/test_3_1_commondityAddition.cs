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
    public class TestLogin_3_1 : StartEnd
    {
        // 使用从CSV读取的数据进行测试
        [Test, TestCaseSource(typeof(AddGoodsTestData), nameof(AddGoodsTestData.GetTestData))]
        public void TestAddGoodsFuc(string trade_name, string selling_price, string purchase_price, string inventory)
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

            // 在“收银”页面，点击“チキン”按钮，并获取“チキン”分类的文本信息
            string category_name = CashInterfacePageOpn.ClickCategoryBtn(4, _driver);

            // 在“收银”页面，在“チキン”分类下，点击“新增商品”按钮（即列表的最后一个元素）
            CashInterfacePageOpn.ClickAddProductBtn(_driver);

            List<string> barCodes = new List<string>();
            for (int i = 0; i < 2; i++)
            {
                // 在“新增商品”页面，点击“生成”按钮，生成随机条码
                NewProductPageOpn.ClickGenerateBarcodeBtn(_driver);

                // 获取生成的条码值
                string barcode = NewProductPageOpn.GetBarcodeInputText(_driver);
                barCodes.Add(barcode);
            }

            // 判断两次生成的条码值是否相等，若相等则报错
            CustomAssertions.AssertNotEqual(barCodes[0], barCodes[1], _driver);

            // 在“新增商品”页面，输入商品名称、售价、进价、库存
            NewProductPageOpn.InputProductName(_driver, trade_name);
            NewProductPageOpn.InputProductStock(_driver, inventory);
            NewProductPageOpn.InputProductPrice(_driver, selling_price);
            NewProductPageOpn.InputProductCost(_driver, purchase_price);

            // 在“新增商品”页面，点击分类下拉框
            NewProductPageOpn.ClickCategoryBtn(_driver);

            // 在分类下拉框中，选择“text=チキン”
            NewProductPageOpn.InputCategorySearch(_driver, "チキン");

            // 在分类下拉框中，点击第一个搜索结果
            NewProductPageOpn.ClickCategoryFirstResult(_driver);

            // 在“分类”下拉框中，点击“保存”按钮
            NewProductPageOpn.ClickCategorySaveBtn(_driver);

            // 点击“保存”按钮,保存新增商品，自动跳转到“收银”页面
            NewProductPageOpn.ClickSaveBtn(_driver);

            // 在“收银”页面，点击“チキン”按钮，并获取“チキン”分类的文本信息
            category_name = CashInterfacePageOpn.ClickCategoryBtn(4, _driver);

            // 获取指定分类序号下,最新添加的商品名和商品售价
            string[] product_name_price = CashInterfacePageOpn.GetNewestProductNameAndPrice(_driver);
            string product_name = product_name_price[0];
            string[] product_price_list = product_name_price[1].Split('￥');
            string product_price = product_price_list[product_price_list.Length - 1];

            // 判断新增商品的名称和价格是否正确
            CustomAssertions.AssertEqual(product_name, trade_name, _driver);
            CustomAssertions.AssertEqual(product_price, selling_price, _driver);
        }
    }

    public class AddGoodsTestData
    {
        /*
            所要读取的csv文件的列名数据结构
         */

        //  该属性的名称必须与CSV文件中列的名称相同（区分大小写）
        public string trade_name { get; set; }
        public string selling_price { get; set; }
        public string purchase_price { get; set; }
        public string inventory { get; set; }

        // 提供测试数据：从CSV文件读取并传递给测试
        public static IEnumerable<object[]> GetTestData()
        {
            // 获取当前文件的相对路径
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // 构造"data"文件夹路径（当前获取的相对路径通常为“appiumtest\bin\Debug\net9.0\”）
            string dataPath = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\data\"));

            // 从文件路径读取测试数据
            string filePath = dataPath + "test_3_1_commodityAddition.csv";  // 指定你的CSV文件路径
            var testDataList = ParseCsv.ReadTestDataFromCsv<AddGoodsTestData>(filePath);

            // 将数据转换为适合TestCaseSource的格式
            foreach (var data in testDataList)
            {
                yield return new object[] { data.trade_name, data.selling_price, data.purchase_price, data.inventory };
            }
        }
    }
}
