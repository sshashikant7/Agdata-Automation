using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UI.Core;

namespace UI.Pages
{
    class CareersPage: BasePage
    {
        //private IWebDriver driver;
        public CareersPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement AllLocationDropdown(string menu) => driver.FindElement(By.XPath("//select[@name='ctl00$pageContent$ctl00$ctl00$jobloc']"));
        private IWebElement AllDeptmentDropdown => driver.FindElement(By.XPath("//select[@name='ctl00$pageContent$ctl00$ctl00$jobdept']"));
        public IList<IWebElement> AllOpenPosition => driver.FindElements(By.XPath("//div[@id='rightcol']//ul[@class='jobs']"));
        public IList<IWebElement> OpenPositionWithRequiredTitle => driver.FindElements(By.XPath("//ul[@class='jobs']"));
        

        public void SwitchToIframe()
        {
            driver.SwitchTo().Frame("HBIFRAME");
        }

        public CareersPage SelectDepartment(string departmentName)
        {
            //SwitchToIframe();
            SelectElement selectDepartment = new SelectElement(AllDeptmentDropdown);
            selectDepartment.SelectByText(departmentName);
            Thread.Sleep(2000);
            return this;
        }
    }
}
