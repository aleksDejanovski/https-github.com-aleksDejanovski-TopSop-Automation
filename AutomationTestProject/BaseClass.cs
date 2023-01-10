using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationTestProject
{
    public class BaseClass
    {
        public IWebDriver driver;
        string webpage = "https://www.topshop.com.mk/";
        public WebDriverWait wait;
       

        [SetUp]
        public void setiranje()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(webpage);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
         
            
            
        }
        [TearDown]
        public void tearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}