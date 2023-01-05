using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using DemoAutomation.Models;
using DemoAutomation.Pages;

namespace DemoAutomation.Interactions
{
    /// <summary>
    /// <b>Proposito:</b> Intenta loguearse en la pagina.
    /// </summary>
    internal class LogIn : ITask
    {
        #region metodos instanciadores

        /// <summary>
        /// <b>Proposito:</b> Dado un usuario y una contraseña intenta ingresar a la pagina.
        /// </summary>
        public static LogIn With(string user, string password)
        {
            return new LogIn(user, password);
        }

        /// <summary>
        /// <b>Proposito:</b> Dado un modelo de usuario intenta ingresar a la pagina.
        /// </summary>
        internal static ITask With(User modelo)
        {
            return new LogIn(modelo.UserName, modelo.Password);
        }

        #endregion

        #region metodos constructores
        public LogIn(string user, string password)
        {
            nombre_de_usuario = user;
            la_contraseña = password;
        }
        #endregion

        #region propiedades
        string nombre_de_usuario { get; set; }
        string la_contraseña { get; set; }

        #endregion

        #region metodo de la interfaz
        public void PerformAs(IActor cualquierActor)
        {
            cualquierActor.AttemptsTo(SendKeys.To(LoginPage.TxtUser, nombre_de_usuario));
            cualquierActor.AttemptsTo(SendKeys.To(LoginPage.TxtPassword, la_contraseña));
            cualquierActor.AttemptsTo(Click.On(LoginPage.BtnLogin));
        }
        #endregion
    }
}
