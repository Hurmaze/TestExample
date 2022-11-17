using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using TestFramework.Enums;

namespace TestsExample
{
    public class BaseTestUI
    {
        public static ChromeDriver driver;
        
        public BaseTestUI()
        {
            ChromeOptions options = new ChromeOptions();
            driver = new ChromeDriver();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void EndTest()
        { 
            driver.Dispose();
        }

        public static IWebElement GetElement(string xpath, int seconds = 20, WaitConditionType conditionType = WaitConditionType.Visible)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            return conditionType switch
            {
                WaitConditionType.Clickable => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(xpath))),
                WaitConditionType.Visible => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath))),
                _ => wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)))
            };
        }

        public static List<IWebElement> GetElements(string xpath, WaitConditionType conditionType = WaitConditionType.Visible, int seconds = 20)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            return conditionType switch
            {
                WaitConditionType.Visible => wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(xpath))).ToList(),
                _ => wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(xpath))).ToList()
            };
        }
    }
}
