using appiumtest.bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appiumtest.Page
{
    public class SettingOperations: BasePage
    {

        // 子类构造函数，接受一个 AndroidDriver 参数
        public SettingOperations(AndroidDriver driver) : base(driver)   // 调用父类的构造函数
        {

        }

        public static void SettingElementClick(int elementIndex)
        {
            /*
                点击指定索引的设置元素
             */
            IList<IWebElement> eles = get_exists_elements(SettingLocators.SettingElements, 1);
            IWebElement ele = eles[elementIndex];
            ele.Click();
        }
    }
}
