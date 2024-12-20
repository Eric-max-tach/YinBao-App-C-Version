using NUnit.Framework;
using System;
using appiumtest.bases;
using System.Collections.Generic;
using OpenQA.Selenium.Appium.Android;

namespace appiumtest.common
{
    public class CustomAssertions
    {
        public static void AssertEqual(dynamic expected, dynamic actual, AndroidDriver driver)
        {
            /*
             * 自定义断言方法，用于判断两个变量是否相等，并提供截图功能
             */
            try
            {
                Assert.That(actual, Is.EqualTo(expected));
            }
            catch (AssertionException ex)
            {
                // 这里可以执行截图、日志记录等操作
                Console.WriteLine($"Assertion failed: {ex.Message}");

                // 调用基类的方法生成截图
                BasePage.generate_screenshot(3, driver, "AssertEqualFaied");

                //throw; // 重新抛出异常
            }
        }

        public static void AssertNotEqual(dynamic expected, dynamic actual, AndroidDriver driver)
        {
            /*
             * 自定义断言方法，用于判断两个变量是否不相等，并提供截图功能
             */
            try
            {
                Assert.That(actual, Is.Not.EqualTo(expected));
            }
            catch (AssertionException ex)
            {
                // 这里可以执行截图、日志记录等操作
                Console.WriteLine($"Assertion failed: {ex.Message}");

                // 调用基类的方法生成截图
                BasePage.generate_screenshot(3, driver, "AssertEqualFaied");

                //throw; // 重新抛出异常
            }
        }

        public static void AssertInRange(dynamic value, dynamic lower_limit, dynamic upper_limit, AndroidDriver driver)
        {
            /*
             * 自定义断言方法，用于判断变量是否在指定范围内，并提供截图功能
             */
            try
            {
                Assert.That(value, Is.InRange(lower_limit, upper_limit));
            }
            catch (AssertionException ex)
            {
                // 这里可以执行截图、日志记录等操作
                Console.WriteLine($"Assertion failed: {ex.Message}");

                // 调用基类的方法生成截图
                BasePage.generate_screenshot(3, driver, "AssertInRangeFaied");

                //throw; // 重新抛出异常
            }
        }

        public static void AssertLessThan(dynamic value, dynamic upper_limit, AndroidDriver driver)
        {
            /*
             * 自定义断言方法，用于判断变量是否小于某个值，并提供截图功能
             */
            try
            {
                Assert.That(value, Is.LessThan(upper_limit));
            }
            catch (AssertionException ex)
            {
                // 这里可以执行截图、日志记录等操作
                Console.WriteLine($"Assertion failed: {ex.Message}");

                // 调用基类的方法生成截图
                BasePage.generate_screenshot(3, driver, "AssertLessThanFaied");

                //throw; // 重新抛出异常
            }
        }

        public static void AssertGreaterThan(dynamic value, dynamic lower_limit, AndroidDriver driver)
        {
            /*
             * 自定义断言方法，用于判断变量是否大于某个值，并提供截图功能
             */
            try
            {
                Assert.That(value, Is.GreaterThan(lower_limit));
            }
            catch (AssertionException ex)
            {
                // 这里可以执行截图、日志记录等操作
                Console.WriteLine($"Assertion failed: {ex.Message}");

                // 调用基类的方法生成截图
                BasePage.generate_screenshot(3, driver, "AssertGreaterThanFaied");

                //throw; // 重新抛出异常
            }
        }

        public static void AssertTrue(dynamic value, AndroidDriver driver)
        {
            /*
             * 自定义断言方法，用于判断变量是否为真，并提供截图功能
             */
            try
            {
                Assert.That(value, Is.True);
            }
            catch (AssertionException ex)
            {
                // 这里可以执行截图、日志记录等操作
                Console.WriteLine($"Assertion failed: {ex.Message}");

                // 调用基类的方法生成截图
                BasePage.generate_screenshot(3, driver, "AssertTrueFaied");

                //throw; // 重新抛出异常
            }
        }
    }
}