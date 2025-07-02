using OpenQA.Selenium.Chromium;
using OpenQA.Selenium;
using System;
using WebDriverManager;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace BDDPRACTICE.Drivers
{
    public class Browsers
    {
        private IWebDriver driver;
        
        public void initial()
        {
            BrowserInitalization("chrome");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void BrowserInitalization(string browser)
        {
            if (browser.ToLower() == "edge")
            {
                new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                driver = new EdgeDriver();
            }
            else if (browser.ToLower() == "firefox")
            {
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver();
            }
            else 
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
            }
        }
        public void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
                driver = null;
            }
        }
    }

}
