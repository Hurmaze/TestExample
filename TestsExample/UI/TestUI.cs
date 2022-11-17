using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Linq;
using TestFramework.Enums;
using TestFramework.Rozetka;

namespace TestsExample
{
    [TestFixture]
    
    [Category("Smoke")]
    public class TestUI : BaseTestUI
    {
        [Test]
        public void TestMethod()
        {
            var url = "https://rozetka.com.ua/";
            driver.Navigate().GoToUrl(url);
            var page = new HomePage(driver);
            var categories = GetElements(page.categories);
            var ca = GetElements(page.categories, WaitConditionType.Clickable);
            var categoriesText = categories.Select(xx => xx.Text).ToList();

            IJavaScriptExecutor executor = (IJavaScriptExecutor) driver;
            executor.ExecuteScript("");

            Assert.True(true);
        }
    }
}
