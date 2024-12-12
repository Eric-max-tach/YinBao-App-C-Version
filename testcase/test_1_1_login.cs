using appiumtest.bases;
using appiumtest.common;
using appiumtest.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appiumtest.testcase
{
    public class TestLogin : StartEnd
    {
        // 使用从CSV读取的数据进行测试
        [Test, TestCaseSource(typeof(LoginTestData), nameof(LoginTestData.GetTestData))]
        public void TestLoginFuc(string username, string password)
        {
            logger.Info("==========test_login==========");

            // 在登录页面的账号输入框中输入用户名
            LoginInPageOpn.InputUsername(username, _driver);

            // 在登录页面的密码输入框中输入密码
            LoginInPageOpn.InputPassword(password, _driver);

            // 点击登录按钮
            LoginInPageOpn.ClickLoginBtn(_driver);

            // 输出 Toast 文本信息
            logger.Info(LoginInPageOpn.GetToastText(_driver));
        }

    }

    public class LoginTestData
    {
        /*
            所要读取的csv文件的列名数据结构
         */

        //  该属性的名称必须与CSV文件中列的名称相同（区分大小写）
        public string username { get; set; }
        public string password { get; set; }

        // 提供测试数据：从CSV文件读取并传递给测试
        public static IEnumerable<object[]> GetTestData()
        {
            // 获取当前文件的相对路径
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // 构造"data"文件夹路径（当前获取的相对路径通常为“appiumtest\bin\Debug\net9.0\”）
            string dataPath = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\data\"));

            // 从文件路径读取测试数据
            string filePath = dataPath + "test_1_1_login.csv";  // 指定你的CSV文件路径
            var testDataList = ParseCsv.ReadTestDataFromCsv<LoginTestData>(filePath);

            // 将数据转换为适合TestCaseSource的格式
            foreach (var data in testDataList)
            {
                yield return new object[] { data.username, data.password };
            }
        }
    }
}
