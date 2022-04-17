using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Pages
{
    class CareersPage
    {
        private IWebDriver driver;
        public CareersPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        private IWebElement AllLocationDropdown(string menu) => driver.FindElement(By.XPath("//select[@name='ctl00$pageContent$ctl00$ctl00$jobloc']"));
        private IWebElement AllDeptmentDropdown => driver.FindElement(By.XPath("//select[@name='ctl00$pageContent$ctl00$ctl00$jobdept']"));
        public IList<IWebElement> AllJobList => driver.FindElements(By.XPath("//div[@id='rightcol']//ul[@class='jobs']"));

        public CareersPage SelectDepartment(string departmentName)
        {
            SelectElement selectDepartment = new SelectElement(AllDeptmentDropdown);
            selectDepartment.SelectByText(departmentName);
            return this;
        }
    }
}
