using Boa.Constrictor.WebDriver;
using DemoAutomation.Interactions;
using DemoAutomation.Models;
using DemoAutomation.Pages;
using NUnit.Framework;
using FluentAssertions;
using Boa.Constrictor.Screenplay;
using System;
using OpenQA.Selenium;

namespace DemoAutomation.Tests
{
    [TestFixture]
    internal class Login : TestBase
    {
        [SetUp]
        public void Before ()
        {
            /* paso de prueba */
            Nami.AttemptsTo(Navigate.ToUrl(Url));

            /* espera sobre elementos */
            Nami.AttemptsTo(
                Wait.Until(Appearance.Of(LoginPage.TxtUser), IsEqualTo.True()),
                Wait.Until(Appearance.Of(LoginPage.TxtPassword), IsEqualTo.True()),
                Wait.Until(Appearance.Of(LoginPage.BtnLogin), IsEqualTo.True())
                );
        }

        [Test]
        public void SuccessfulLogin()
        {
            Nami.AttemptsTo(LoginSimple.With( User.StandardUser() ));

            /* assert combinando boa.constrictor y fluentAssertion */
            Nami.AsksFor(Appearance.Of(InventoryPage.LogoShoppingCart)).Should().BeTrue();
                
        }

        [Test]
        public void IntentionalFailure()
        {
            string FailUrlImg = "https://www.dfordog.co.uk/user/images/funnies/dog-fail-frisbee.jpg";
            Nami.AttemptsTo(Navigate.ToUrl(FailUrlImg));
            Assert.Fail();
        }

        [Test]
        public void InvalidPasswordLogin()
        {
            Nami.AttemptsTo(LogIn.With( User.StandardUserWithInvalidPassword() ));
            Nami.AskingFor(Appearance.Of(LoginPage.LblError)).Should().BeTrue();
        }

        [Test]
        public void LoginWithBlockedUser()
        {
                Nami.AttemptsTo(LogIn.With( User.LockedOutUser() ));
                Nami.AskingFor(Appearance.Of(LoginPage.LblError)).Should().BeTrue();
        }
    }
}





