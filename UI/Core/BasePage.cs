using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Core
{
    class BasePage
    {
        private static IWebElement _webElement;
        public IWebDriver driver;
        public BasePage(IWebDriver _driver)
        {
            driver = _driver;
        }

    }
}
