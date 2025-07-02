using System;
using System.Xml.Linq;
using BDDPRACTICE.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using Reqnroll;

namespace BDDPRACTICE.StepDefinitions
{
    [Binding]
    public class AmazonTvSearchStepDefinitions : Browsers
    {
        private IWebDriver driver;
        [Given("I am on the amazon home page")]
        public void GivenIAmOnTheAmazonHomePage()
        {
            
            driver.Navigate().GoToUrl("https://amazon.in");
            Thread.Sleep(3000);
        }

        [When("I enter smart tv in the search bar {string}and I click on the search button")]
        public void WhenIEnterSmartTvInTheSearchBarAndIClickOnTheSearchButton(string TVName)
        {
            IWebElement Searchbox = driver.FindElement(By.XPath("//input[@id='twotabsearchtextbox']"));
            Searchbox.SendKeys(TVName);
            Searchbox.SendKeys(Keys.Enter);
        }

        [When("I selected a acer tv and I click on the tv and added to cart")]
        public void WhenISelectedAAcerTvAndIClickOnTheTvAndAddedToCart()
        {
            IWebElement OneplusTV43inch = driver.FindElement(By.XPath("//span[contains(text(),'Smart Google TV AR43UDIGU2875AT (Black)')]"));
            OneplusTV43inch.Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("(//input[@id='add-to-cart-button'])[2]")).Click();
        }

        [Then("I Assert whether tv added to kart or not")]
        public void ThenIAssertWhetherTvAddedToKartOrNot()
        {
            IWebElement Check = driver.FindElement(By.Name("proceedToRetailCheckout"));
            Assert.IsTrue(Check.GetAttribute("name") == "proceedToRetailCheckout", "Item not added to cart");
            driver.Quit();
            driver.Dispose();
        }



        [Given("I am on the amazon home page and I click on the signin")]
            public void GivenIAmOnTheAmazonHomePageAndIClickOnTheSignin()
            {
                throw new PendingStepException();
            
            }

            [When("I enter Username and then I click on the continue button")]
            public void WhenIEnterUsernameAndThenIClickOnTheContinueButton()
            {
                throw new PendingStepException();
            }

            [When("I enter Password and click on the Signin button")]
            public void WhenIEnterPasswordAndClickOnTheSigninButton()
            {
                throw new PendingStepException();
            }

            [Then("I Assert the login successfully")]
            public void ThenIAssertTheLoginSuccessfully()
            {
                throw new PendingStepException();
            }


    }
}
