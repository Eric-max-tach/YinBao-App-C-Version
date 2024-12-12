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
}
