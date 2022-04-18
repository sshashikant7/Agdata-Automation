using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Core;

namespace UI
{
    [TestFixture]
    class Hooks
    {
        string applicationURL = "http://www.agdata.com/";

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Driver.StartBrowser(BrowserTypes.Chrome, 60);
            Driver.Browser.Navigate().GoToUrl(applicationURL);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver.StopBrowser();
        }
    }
}
