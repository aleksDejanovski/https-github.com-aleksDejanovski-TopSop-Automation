using OpenQA.Selenium;

namespace AutomationTestProject
{
    internal class CostumerPage
    {
        private IWebDriver driver;

        public CostumerPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //element za dokaz deka korisnikot e logiran
        public IWebElement DokazDekaELogiran => driver.FindElement(By.CssSelector("div[class='account-box'] div[class='account-hdr account-hdr-row-one clearfix'] h2"));

    }
}