using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using DemoAutomation.Pages;

namespace DemoAutomation.Interactions
{
    internal class EmptyThatShoppingCart : ITask
    {
        #region metodo instanciador
        public static EmptyThatShoppingCart IfItHaveAProduct () => new EmptyThatShoppingCart();

        #endregion

        #region metodo de la interfaz
        public void PerformAs(IActor algunActor)
        {
            algunActor.AttemptsTo(Click.On(InventoryPage.LogoShoppingCart));

            while ( algunActor.AskingFor(Appearance.Of(CartPage.LblCartItem)) == true )
            {
                algunActor.AttemptsTo(Click.On(CartPage.BtnRemoveItem));
            }

            algunActor.AttemptsTo(Click.On(CartPage.BtnContinueShopping));
        }
        #endregion
    }
}
