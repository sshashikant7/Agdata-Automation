using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using UI.Core;
using UI.Pages;

namespace UI
{
    [TestFixture]
    public class Tests
    {
        //public IWebDriver driver;
        string applicationURL = "http://www.agdata.com/";


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Driver.StartBrowser(BrowserTypes.Chrome, 60);
            Driver.Browser.Manage().Window.Maximize();
            Driver.Browser.Navigate().GoToUrl(applicationURL);
        }

        [Test]
        public void ListOfOpenJobs()
        {
            Header header = new Header(Driver.Browser);
            CareersPage careersPage = new CareersPage(Driver.Browser);
            header.NavigateToPage("Company", "Careers");
            careersPage.SwitchToIframe();
            var jobList = careersPage.AllOpenPositionWithRequiredTitle;
            Console.WriteLine($"============== All available Job List - Count - {jobList.Count}=========================");
            foreach (IWebElement ele in jobList)
                Console.WriteLine(ele.Text);
            careersPage.SelectDepartment("Engagement/Project Management");
            jobList = careersPage.OpenPositionWithRequiredTitle;
            Console.WriteLine($"============== Job with title contain Manager  Count - {jobList.Count}=========================");
            foreach (IWebElement ele in jobList)
                Console.WriteLine(ele.Text);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver.StopBrowser();
        }
    }
}