using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Rozetka
{
    public class HomePage : BasePage
    {
        public HomePage(ChromeDriver driver)
            : base(driver)
        {
        }

        #region Elements
        public string categories = "//*[@class='menu-categories__link']";
        #endregion
    }
}
