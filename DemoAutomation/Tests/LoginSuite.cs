using Boa.Constrictor.WebDriver;
using DemoAutomation.Interactions;
using DemoAutomation.Models;
using NUnit.Framework;

namespace DemoAutomation.Tests
{
    [TestFixture]
    internal class LoginSuite : TestBase
    {
        [SetUp]
        public void Before ()
        {
            Nami.AttemptsTo(Navigate.ToUrl(Url));
            Nami.AttemptsTo(Espera.UnTiempo("10"));
        }

        [Test]
        public void PositiveLogin()
        {
            Nami.AttemptsTo(LoginProfesional.With( User.Default() ));
        }

        [Test]
        public void InvalidPasswordLogin()
        {
            Nami.AttemptsTo(LoginProfesional.With( User.InvalidPassword() ));
        }

        [Test]
        public void InvalidUserLogin()
        {
            Nami.AttemptsTo(LoginProfesional.With( User.InvalidUser() ));
        }
    }
}
