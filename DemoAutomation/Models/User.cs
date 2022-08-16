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
        public static User Default() => new User("Admin", "Admin123");

        /// <summary>
        /// Modelo con nombre de usuario valido y contraseña invalida.
        /// </summary>
        public static User InvalidPassword() => new User("Admin", "Invalid123");

        /// <summary>
        /// Modelo con nombre de usuario invalido.
        /// </summary>
        public static User InvalidUser() => new User("Invalid", "Admin123");

        public User(string v1, string v2)
        {
            UserName = v1;
            Password = v2;
        }

        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
