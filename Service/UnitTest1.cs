//using NUnit.Framework;
using Common.ConfigManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Service
{
    [TestFixture]
    public class PostService
    {
        public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext { get; set; }
        ConfigManager configManager;
        [OneTimeSetUp]
        public void OneTimeSetUp()

        {
            configManager = new ConfigManager(TestContext);
        }

        [Test]
        public void FirstServiceTest()
        {
            var apiurl = configManager.BaseAPIUrl;
            var uiurl = configManager.BaseUIUrl;

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
        }
    }
}