using OpenQA.Selenium;

namespace AutomationTestProject
{
    internal class Homepage
    {
        private IWebDriver driver;

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
        }
        //element domacinstvo
        public IWebElement Domacinstvo => driver.FindElement(By.XPath("//span[contains(text(),'Домаќинство')]"));

        public IWebElement TitleDomacinstvo => driver.FindElement(By.CssSelector("div[class='page-title category-title clearfix'] h1"));

        public void DomacinstvoKlik()
        {
            Domacinstvo.Click();
        }

    }
}