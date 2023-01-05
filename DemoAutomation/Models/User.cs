namespace DemoAutomation.Models
{
    /// <summary>
    /// Modelo de datos de usuario.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Modelo con nombre de usuario y contraseña validas.
        /// </summary>
        public static User StandardUser() => new User("standard_user", "secret_sauce");

        /// <summary>
        /// Modelo con nombre de usuario standard y contraseña invalida.
        /// </summary>
        public static User StandardUserWithInvalidPassword() => new User("standard_user", "Invalid");

        /// <summary>
        /// Modelo con nombre de usuario y contraseña de un usuario bloqueado.
        /// </summary>
        public static User LockedOutUser() => new User("locked_out_user", "secret_sauce");

        /// <summary>
        /// Modelo con nombre de usuario y contraseña de un usuario con problemas.
        /// </summary>
        public static User ProblemUser() => new User("problem_user", "secret_sauce");

        /// <summary>
        /// Modelo con nombre de usuario y contraseña de un usuario con fallos de rendimiento.
        /// </summary>
        public static User PerformanceGlitchUser() => new User("performance_glitch_user", "secret_sauce");

        public User(string v1, string v2)
        {
            UserName = v1;
            Password = v2;
        }

        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
