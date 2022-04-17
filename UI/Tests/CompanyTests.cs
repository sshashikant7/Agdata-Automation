using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using UI.Pages;

namespace UI
{
    public class Tests
    {
        public IWebDriver driver;
        string applicationURL = "http://www.agdata.com/";
        

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var chromeExeDriverPath = $"{Environment.CurrentDirectory}/SeleniumSupport/ChromeDriver/";
            driver = new ChromeDriver(chromeExeDriverPath);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(applicationURL);
        }

        [Test]
        public void ListOfOpenJobs()
        {
            Header header = new Header(driver);
            CareersPage careersPage = new CareersPage(driver);
            header.NavigateToPage("Company", "Careers");
            var jobList = careersPage.AllJobList;

            Assert.Pass();
        }

        [Test]
        public void ListOfJobsForManager()
        {
            //Header header = new Header(driver);
            //header.NavigateToPage("Company", "Careers");
            CareersPage careersPage = new CareersPage(driver);
            careersPage.SelectDepartment("Engagement/Project Management");

            Assert.Pass();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
        }
    }
}