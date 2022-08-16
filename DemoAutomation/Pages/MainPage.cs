using Boa.Constrictor.WebDriver;
using static Boa.Constrictor.WebDriver.WebLocator;
using OpenQA.Selenium;

namespace DemoAutomation.Pages
{
    internal class MainPage
    {
        #region SideBar
        public static IWebLocator Admin => L("el nombre del menu Administrador", By.Id("menu_admin_viewAdminModule"));
        public static IWebLocator NationalitiesOption => L("el nombre del menu Nationalities", By.Id("menu_admin_nationality"));
        #endregion
    }
}
