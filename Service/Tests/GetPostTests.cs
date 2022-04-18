//using NUnit.Framework;
using Common.ConfigManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Service.Request;
using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Service
{
    [TestFixture]
    public class PostService
    {

        public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext { get; set; }
        ConfigManager configManager;
        Services Services = new Services();
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            //configManager = new ConfigManager(TestContext);
        }

        [Test]
        public void FirstGetServiceTest()
        {
            var list = Services.GetPosts();
            //Services.GetPosts();
        }

        [Test]
        public void FirstPostServiceTest()
        {
            try
            {
                PostRequest request = new PostRequest(_userId: 1, _title: "Automation Title", _body: "Automation Body");
                Services.PostPosts(request);
            }
            catch(Exception ex)
            {

            }
        }

        public void FirstPutServiceTest()
        {
            try
            {
                PutRequest request = new PutRequest(_userId: 1, _id:1, _title: "Automation Title", _body: "Automation Body");
                Services.PutPost(request,"1");
            }
            catch (Exception ex)
            {

            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
        }
    }
}