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
            var jobList = careersPage.AllJobList;

            Assert.Pass();
        }

        [Test]
        public void ListOfJobsForManager()
        {
            //Header header = new Header(driver);
            //header.NavigateToPage("Company", "Careers");
            CareersPage careersPage = new CareersPage(Driver.Browser);
            careersPage.SelectDepartment("Engagement/Project Management");
            Assert.Pass();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver.StopBrowser();
        }
    }
}