using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using DemoAutomation.Models;
using DemoAutomation.Pages;

namespace DemoAutomation.Interactions
{
    /// <summary>
    /// <b>Proposito:</b> Intenta loguearse en la pagina.
    /// </summary>
    internal class LoginProfesional : ITask
    {
        #region metodos instanciadores

        /// <summary>
        /// <b>Proposito:</b> Dado un usuario y una contraseña intenta ingresar a la pagina.
        /// </summary>
        public static LoginProfesional With(string user, string password)
        {
            return new LoginProfesional(user, password, "normal");
        }

        /// <summary>
        /// <b>Proposito:</b> Dado un modelo de usuario intenta ingresar a la pagina.
        /// </summary>
        internal static ITask With(User modelo)
        {
            return new LoginProfesional(modelo.UserName, modelo.Password, "normal");
        }

        /// <summary>
        /// <b>Proposito:</b> Dado un modelo intenta ingresar a la pagina.
        /// </summary>
        internal static ITask Model(User modelo)
        {
            return new LoginProfesional(modelo, "modelo");
        }

        #endregion

        #region metodos constructores
        public LoginProfesional(string user, string password, string methodtype)
        {
            nombre_de_usuario = user;
            la_contraseña = password;
            MethodType = methodtype;
        }

        public LoginProfesional(User modelo, string methodtype)
        {
            Modelo = modelo;
            MethodType = methodtype;
        }

        #endregion

        #region propiedades
        string nombre_de_usuario { get; set; }
        string la_contraseña { get; set; }
        public User Modelo { get; }
        public string MethodType { get; set; }

        #endregion

        #region metodo de la interfaz
        public void PerformAs(IActor cualquierActor)
        {
            switch (MethodType)
            {
                case "normal":
                    cualquierActor.AttemptsTo(SendKeys.To(LoginPage.TxtUser, nombre_de_usuario));
                    cualquierActor.AttemptsTo(SendKeys.To(LoginPage.TxtPassword, la_contraseña));
                    break;
                case "modelo":
                    cualquierActor.AttemptsTo(SendKeys.To(LoginPage.TxtUser, Modelo.UserName));
                    cualquierActor.AttemptsTo(SendKeys.To(LoginPage.TxtPassword, Modelo.Password));
                    break;
            }

            cualquierActor.AttemptsTo(Click.On(LoginPage.BtnIngresar));
        }


        #endregion
    }
}
