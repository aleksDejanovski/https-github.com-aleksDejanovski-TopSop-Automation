using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationTestProject
{
    [TestFixture]
    public class TestCases : BaseClass

    {
        [Test]
        public void DomacinstvoElements()
        {
            page.DomacinstvoKlik();
            Assert.IsTrue(page.TitleDomacinstvo.Text.Contains("Домаќинство"));
        }
        [Test]
        public void KujnaElement()
        {
            page.KujnaKlik();
            Assert.IsTrue(page.KujnaKliknata.Text.Contains("Kујна"));
        }
        [Test]
        public void ElektricniAparati()
        {
            page.KujnaKlik();
            pageKujna.ElektrickiAparatiClick();
            Assert.AreEqual("Електрични апарати", pageKujna.OtvoreniElektricni.Text);
        }
        [Test]
        public void SpalnaImaElementi()
        {
            page.DomacinstvoKlik();
            pageDomacinstvo.SpalnaClick();
            Assert.IsTrue(driver.Url.Contains("spalna"));

        }
        [Test]
        public void RegistracijaUserSeOtvara()
        {
            page.DomacinstvoKlik();
            page.registracijaKlik();
            Assert.IsTrue(pageRegis.PageTitleDokaz.Text.Contains("Креирајте корисничка сметка"));
        }
        [Test]
        public void Registracijaforma()
        {
            int num = rnd.Next();
            string userName1 = "denkovski112" + num * 10000 + "a@yahoo.com";
            page.DomacinstvoKlik();
            page.registracijaKlik();
            pageRegis.EnterName("Aleksandar");
            pageRegis.EnterSurname("Damjanovski");
            pageRegis.EnterEmail(userName1);
            pageRegis.EnterAdress("Ulica 12 broj 2");
            pageRegis.EnterPostenski("1300");
            pageRegis.EnterPhone("070648549");
            pageRegis.EnterPass("acecar");
            pageRegis.EnterPassConf("acecar");
            pageRegis.RegistrationClick();

            // THE TEST FAILS BECAUSE CAPCHA ELEMENT OCCURES AND I DONT KNOW HOW TO AUTOMATE IT

            Assert.AreEqual("Ви благодариме што се регистриравте.", pageRegis.RegistrationSuccess.Text, "The User Is Not Registered");
        }
        [Test]
        public void LoginForma()
        {
            page.NajavaClick();
            pageLogin.LoginSubmit("denkovski112a@yahoo.com", "acecar");
            Assert.AreEqual("Информации за корисничката сметка", pageCostumer.DokazDekaELogiran.Text, "The user is NOT logged in");
        }
        [Test]
        public void LoginThenAddToChart()
        {
            page.NajavaClick();
            pageLogin.LoginSubmit("denkovski112a@yahoo.com", "acecar");
            pageCostumer.SportKlik();
            Thread.Sleep(2000);
            pageCostumer.CookieeKlik();
            pageCostumer.EMSTonerPovekeKlik();
            pageCostumer.KosnickaKlik();
            Assert.IsTrue(pageCart.SuccesMessageForCard.Text.Contains("е додаден во вашата кошничка"));
        }
    }
}


