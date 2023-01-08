using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTestProject
{
    [TestFixture]
    public class TestCases
    {
        IWebDriver driver;
        string webpage = "https://www.topshop.com.mk/";
        Homepage page;

        [SetUp]
        public void setiranje()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(webpage);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            page = new Homepage(driver);
        }
        [TearDown]
        public void tearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
        [Test]
        public void frontPageElements()
        {
            page.DomacinstvoKlik();
            Assert.IsTrue(page.TitleDomacinstvo.Text.Contains("Домаќинство"));
        }
    }

}
