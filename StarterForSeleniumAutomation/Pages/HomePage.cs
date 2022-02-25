using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SpotFinderWebSeleniumTests.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotFinderWebSeleniumTests.Pages
{
    public class HomePage : Page
    {
        #region IWebelements
        #region HomePage
        [FindsBy(How = How.XPath, Using = "//*[text()='Witaj w  SpotFinder. Zaloguj się.']")]
        private IWebElement WelcomeText;

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement UserNameInput;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement PasswordInput;

        [FindsBy(How = How.XPath, Using = "//*[text()='Zaloguj się!']")]
        private IWebElement LogInButton;
        #endregion
        #endregion

        /// <summary>
        /// Call the base class constructor
        /// </summary>
        /// <param name="browser"></param>
        public HomePage(IWebDriver browser) : base(browser) { }

        /// <summary>
        /// Searches for 'search' on google home page
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void LogIn(string username, string password)
        {
            UserNameInput.SendKeys(username);
            PasswordInput.SendKeys(password);
            PasswordInput.SendKeys(Keys.Enter);
        }

        /// <summary>
        /// Clicks the first result of a search and returns the links text
        /// </summary>
        public string ClickFirstResult()
        {
            IWebElement link = driver.FindElements(By.ClassName("g"))[0].FindElement(By.TagName("a"));
            string text = link.Text;
            link.Click();
            return text;
        }

        public override void NavigateToPage(string parameter = "")
        {
             this.driver.Navigate().GoToUrl(ConstantStrings.GetUrl());
        }
        
    }
}
