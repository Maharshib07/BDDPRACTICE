using BDDPRACTICE.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V132.Audits;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDPRACTICE.Pages
{
    public class AmazonPage
    {
        public readonly IWebDriver driver;
        //private readonly Actions actions;
        public AmazonPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement HoveronLogin => driver.FindElement(By.PartialLinkText("Hello, sign in"));
        private IWebElement Username => driver.FindElement(By.XPath("//input[@id='ap_email_login']"));
        private IWebElement Continue => driver.FindElement(By.XPath("//input[@type='submit']"));
        private IWebElement Password => driver.FindElement(By.XPath("//input[@name='password']"));
        private IWebElement AssLogin => driver.FindElement(By.XPath("//span[text()='Hello, Maharshi']"));


        //public void Login(string username, string password)
        //{
        //    HoveronLogin.Click();
        //    Username.SendKeys(username);
        //    Continue.Click();
        //    Password.SendKeys(password);
        //    Continue.Click();
        //    //string Ass= AssLogin.Text;
        //    Assert.IsTrue(AssLogin.Displayed, "User not Login");
        //}

    }
}
