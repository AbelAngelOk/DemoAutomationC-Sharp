using Boa.Constrictor.WebDriver;
using static Boa.Constrictor.WebDriver.WebLocator;
using OpenQA.Selenium;

namespace DemoAutomation.Pages
{
    internal class LoginPage
    {
        internal static IWebLocator BtnIngresar => L("el boton ingresar", By.XPath("//button[contains(.,'Login')]"));
        public static IWebLocator TxtUser => L("el campo de usuario", By.XPath("//*[@name='username']")); 
        public static IWebLocator TxtPassword => L("el campo d contraseña", By.XPath("//*[@name='password']")); 
    }
}
