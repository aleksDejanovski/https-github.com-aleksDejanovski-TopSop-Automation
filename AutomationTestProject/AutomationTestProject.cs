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
    public class TestCases : BaseClass

    {
        [Test]
        public void DomacinstvoElements()
        {
            Homepage page = new Homepage(driver);
            page.DomacinstvoKlik();
            Assert.IsTrue(page.TitleDomacinstvo.Text.Contains("Домаќинство"));
        }
        [Test]
        public void KujnaElement()
        {
            Homepage page = new Homepage(driver);
            page.KujnaKlik();
            Assert.IsTrue(page.KujnaKliknata.Text.Contains("Kујна"));
        }
        [Test]
        public void ElektricniAparati()
        {
            Homepage page = new Homepage(driver);
            page.KujnaKlik();
            KujnaPage pageKujna = new KujnaPage(driver);
            pageKujna.ElektrickiAparatiClick();
            Assert.AreEqual("Електрични апарати", pageKujna.OtvoreniElektricni.Text);
        }
        [Test]
        public void SpalnaImaElementi()
        {
            Homepage page = new Homepage(driver);
            page.DomacinstvoKlik();
            DomacinstvoPage pageDomacinstvo = new DomacinstvoPage(driver);
            pageDomacinstvo.SpalnaClick();
            Assert.IsTrue(driver.Url.Contains("spalna"));
            
        }
    }
}


