using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UI.Core;

namespace UI.Pages
{
    class Header: BasePage
    {
        //private IWebDriver driver;
        public Header(IWebDriver driver):base(driver)
        {
        }

        private IWebElement NevigationMenu(string menu) => driver.FindElement(By.XPath($"//*[@id='masthead']//a[contains(text(),'{menu}')]"));
        private IWebElement NevigationSubMenu(string submenu) => driver.FindElement(By.XPath($"//*[@id='masthead']//a[contains(text(),'{submenu}')]"));

        public Header NavigateToPage(string menu,string subMenu)
        {
            NevigationMenu(menu).Click();
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(NevigationMenu(menu)).Build().Perform();
            Thread.Sleep(2000);
            NevigationSubMenu(subMenu).Click();
            return this;
        }
    }
}
