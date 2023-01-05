using Boa.Constrictor.WebDriver;
using static Boa.Constrictor.WebDriver.WebLocator;
using OpenQA.Selenium;
using Boa.Constrictor.Screenplay;

namespace DemoAutomation.Pages
{
    internal class LoginPage
    {
        internal static IWebLocator TxtUser => L("el campo de usuario", By.Id("user-name"));
        public static IWebLocator TxtPassword => L("el campo de contraseña", By.Id("password")); 
        public static IWebLocator BtnLogin => L("el boton ingresar", By.Id("login-button"));
        public static IWebLocator LblError => L("el texto de advertencia", By.XPath("//h3"));
    }
}
