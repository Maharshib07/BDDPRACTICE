using System;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;

namespace BDDPRACTICE.StepDefinitions
{
    [Binding]
    public class AmazonTvSearchStepDefinitions
    {
        IWebDriver driver;
        [Given("I am on the amazon home page")]
        public void GivenIAmOnTheAmazonHomePage()
        {
            driver = new ChromeDriver();
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



        [Then("I checked whether tv added to kart or not")]
        public void ThenICheckedWhetherTvAddedToKartOrNot()
        {
            IWebElement Check = driver.FindElement(By.Name("proceedToRetailCheckout"));
            Assert.IsTrue(Check.GetAttribute("name") == "proceedToRetailCheckout", "Item not added to cart");
        }

    }
}
