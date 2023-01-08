using OpenQA.Selenium;

namespace AutomationTestProject
{
    internal class Homepage : BaseClass
    {
        private IWebDriver driver { get; set; }

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
        }
        //element domacinstvo
        public IWebElement Domacinstvo => driver.FindElement(By.XPath("//span[contains(text(),'Домаќинство')]"));

        public IWebElement TitleDomacinstvo => driver.FindElement(By.CssSelector("div[class='page-title category-title clearfix'] h1"));

        //element kujna
        public IWebElement Kujna => driver.FindElement(By.XPath("//span[contains(text(),'Kујна')]"));

        //dokaz deka e kliknata kujna
        public IWebElement KujnaKliknata => driver.FindElement(By.CssSelector("div[class='page-title category-title clearfix'] h1"));


        public DomacinstvoPage DomacinstvoKlik()
        {
            Domacinstvo.Click();
            return new DomacinstvoPage(driver);
        }
        public KujnaPage KujnaKlik()
        {
            Kujna.Click();
            return new KujnaPage(driver);
        }
    }
}