using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using DemoAutomation.Models;
using DemoAutomation.Pages;

namespace DemoAutomation.Interactions
{    /// <summary>
     /// <b>Proposito:</b> Intenta ingresar a la pagina.
     /// </summary>
    internal class LoginSimple
    {
        /// <summary>
        /// <b>Proposito:</b> Dado un usuario y una contraseña intenta ingresar a la pagina.
        /// </summary>
        public static ITask With (string user, string password)
        {
            return RunTasks.InOrder(
            SendKeys.To(LoginPage.TxtUser, user),
            SendKeys.To(LoginPage.TxtPassword, password),
            Click.On(LoginPage.BtnLogin)
            );
        }

        /// <summary>
        /// <b>Proposito:</b> Dado un modelo de usuario intenta ingresar a la pagina.
        /// </summary>
        public static ITask With(User modelo)
        {
            return RunTasks.InOrder(
            SendKeys.To(LoginPage.TxtUser, modelo.UserName),
            SendKeys.To(LoginPage.TxtPassword, modelo.Password),
            Click.On(LoginPage.BtnLogin)
            );
        }
    }
}
