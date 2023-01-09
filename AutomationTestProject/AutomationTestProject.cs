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
        [Test]
        public void RegistracijaUserSeOtvara()
        {
            Homepage page = new Homepage(driver);
            page.DomacinstvoKlik();
            page.registracijaKlik();
            RegistracijaPage pageRegis = new RegistracijaPage(driver);
            Assert.IsTrue(pageRegis.PageTitleDokaz.Text.Contains("Креирајте корисничка сметка"));
        }
        [Test]
        public void Registracijaforma()
        {
            Random rnd = new Random();
            int num = rnd.Next();
            string userName1 = "denkovski112" + num * 10000 + "a@yahoo.com";
            Homepage page = new Homepage(driver);
            page.DomacinstvoKlik();
            page.registracijaKlik();
            RegistracijaPage pageRegis = new RegistracijaPage(driver);
            pageRegis.EnterName("Aleksandar");
            pageRegis.EnterSurname("Damjanovski");
            pageRegis.EnterEmail(userName1);
            pageRegis.EnterAdress("Ulica 12 broj 2");
            pageRegis.EnterPostenski("1300");
            //pageRegis.EnterCity("Kumanovo");
            pageRegis.EnterPhone("070648549");
            pageRegis.EnterPass("acecar");
            pageRegis.EnterPassConf("acecar");
            pageRegis.RegistrationClick();
            Assert.AreEqual("Ви благодариме што се регистриравте.", pageRegis.RegistrationSuccess.Text, "The User Is Not Registered");
        }
        [Test]
        public void LoginForma()
        {
            Homepage page = new Homepage(driver);
            page.NajavaClick();
            LoginPage pageLogin = new LoginPage(driver);
            pageLogin.LoginSubmit("denkovski112a@yahoo.com", "acecar");
            CostumerPage pageCostumer = new CostumerPage(driver);
            Assert.AreEqual("Информации за корисничката сметка", pageCostumer.DokazDekaELogiran.Text, "The user is NOT logged in");
        }
    }
}


