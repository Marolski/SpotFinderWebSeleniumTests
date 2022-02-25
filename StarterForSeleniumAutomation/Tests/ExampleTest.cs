using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpotFinderWebSeleniumTests.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpotFinderWebSeleniumTests.Tests
{
    [TestClass]
    public class ExampleTest : BaseTest
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            testContextInstance = context;
        }
        
        [TestInitialize]
        public void TestInitialization()
        {
            LaunchBrowser(ConstantStrings.GetUrl());
        }

        [TestMethod]
        public void Test()
        {
            #region Test Data
            string username = "mbrzoska303@gmail.com";
            string password = "Marol12#";
            #endregion

            //Searches google
            homePage.LogIn(username, password);
            
            //Check User is loged in
            string linkText = homePage.ClickFirstResult();
            
            //Verifies the link had some text
            Assert.IsNotNull(linkText, "The link had no text.");
            Assert.IsFalse(linkText.Equals(""), "The resulted in an empty string.");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            CloseBrowser();
        }
    }
}
