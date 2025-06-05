using System;
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

        [When("I enter smart tv in the search bar and I click on the search button")]
        public void WhenIEnterSmartTvInTheSearchBarAndIClickOnTheSearchButton()
        {
            IWebElement Searchbox = driver.FindElement(By.XPath("//input[@id='twotabsearchtextbox']"));
            Searchbox.SendKeys("Oneplus 43inch tv");
            Searchbox.SendKeys(Keys.Enter);
        }

        [When("I selected a oneplus tv and I click on the tv")]
        public void WhenISelectedAOneplusTvAndIClickOnTheTv()
        {
            IWebElement OneplusTV43inch = driver.FindElement(By.XPath(""));
        }


        [Then("I should see a list of tvs in the search results")]
        public void ThenIShouldSeeAListOfTvsInTheSearchResults()
        {
            throw new PendingStepException();
        }
    }
}
