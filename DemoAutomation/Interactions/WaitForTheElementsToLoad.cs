using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using DemoAutomation.Pages;

namespace DemoAutomation.Interactions
{
    /// <summary>
    /// Proposito: Dado una pagina espera que cargen los principales elementos.
    /// </summary>
    internal class WaitForTheElementsToLoad 
    {

        /// <summary>
        /// Proposito: Espera los principales elementos de la pagina de logueo.
        /// </summary>
        public static ITask OfLoginPage()
        {
            return RunTasks.InOrder(
                Wait.Until(Appearance.Of(LoginPage.TxtUser), IsEqualTo.True()),
                Wait.Until(Appearance.Of(LoginPage.TxtPassword), IsEqualTo.True()),
                Wait.Until(Appearance.Of(LoginPage.BtnLogin), IsEqualTo.True())
            );
        }
    }
}
