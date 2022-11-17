using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestFramework
{
    public class BasePage
    {
        public ChromeDriver driver;

        public BasePage(ChromeDriver driver)
        {
            this.driver = driver;
        }
    }
}
