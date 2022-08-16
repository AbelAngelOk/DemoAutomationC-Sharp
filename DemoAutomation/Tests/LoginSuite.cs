using Boa.Constrictor.WebDriver;
using DemoAutomation.Interactions;
using DemoAutomation.Models;
using NUnit.Framework;

namespace DemoAutomation.Tests
{
    internal class LoginSuite : TestBase
    {
        [Test]
        public void PositiveLogin()
        {
            Nami.AttemptsTo(Navigate.ToUrl(Url));
            Nami.AttemptsTo(Espera.UnTiempo("10"));
            Nami.AttemptsTo(LoginProfesional.With( User.Default() ));
        }

        [Test]
        public void InvalidPasswordLogin()
        {
            Nami.AttemptsTo(Navigate.ToUrl(Url));
            Nami.AttemptsTo(Espera.UnTiempo("10"));
            Nami.AttemptsTo(LoginProfesional.With( User.InvalidPassword() ));
        }

        [Test]
        public void InvalidUserLogin()
        {
            Nami.AttemptsTo(Navigate.ToUrl(Url));
            Nami.AttemptsTo(Espera.UnTiempo("10"));
            Nami.AttemptsTo(LoginProfesional.With( User.InvalidUser() ));
        }
    }
}
