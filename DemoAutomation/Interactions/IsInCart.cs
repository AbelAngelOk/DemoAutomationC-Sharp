using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using DemoAutomation.Pages;
using static Boa.Constrictor.WebDriver.WebLocator;
using OpenQA.Selenium;

namespace DemoAutomation.Interactions
{
    internal class IsInCart : IQuestion<bool>
    {
        #region metodos instanciadores
        public static IsInCart OneProduct() => new IsInCart(1);
        public static IsInCart TheProducts(int cant) => new IsInCart(cant);
        #endregion

        #region metodo constructor
        public IsInCart(int cant)
        {
            NumberOfElement = cant;
        }
        #endregion

        #region propiedades
        int NumberOfElement { get; set; }
        #endregion

        #region metodo de la interfaz
        public bool RequestAs(IActor cualquierActor)
        {
            cualquierActor.AttemptsTo(Click.On(InventoryPage.LogoShoppingCart));

            return cualquierActor.AskingFor(
                Appearance.Of(
                    L("", 
                       By.ClassName("//*[@class='cart_item'][" + NumberOfElement + "]"))
                    )
                );
        }
        #endregion
    }
}
