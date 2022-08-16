using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using DemoAutomation.Pages;

namespace DemoAutomation.Interactions
{    /// <summary>
     /// <b>Proposito:</b> Intenta ingresar a la pagina.
     /// </summary>
    internal class Login
    {
        /// <summary>
        /// <b>Proposito:</b> Dado un usuario y una contraseña intenta ingresar a la pagina.
        /// </summary>
        public static ITask With (string user, string password)
        {
            return RunTasks.InOrder(
            SendKeys.To(LoginPage.TxtUser, user),
            SendKeys.To(LoginPage.TxtPassword, password),
            Click.On(LoginPage.BtnIngresar)
            );
        }
    }
}
