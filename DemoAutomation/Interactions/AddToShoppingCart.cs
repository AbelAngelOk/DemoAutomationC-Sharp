using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using DemoAutomation.Pages;
using System;

namespace DemoAutomation.Interactions
{
    internal class AddToShoppingCart
    {

        public static ITask OneProduct()
        {
            return RunTasks.InOrder(
                Click.On(InventoryPage.BtnAddToCard_Backpack)
            );
        }

        internal static ITask TwoProducts()
        {
            return RunTasks.InOrder(
                Click.On(InventoryPage.BtnAddToCard_Backpack),
                Click.On(InventoryPage.BtnAddToCard_BikeLight)
            );
        }
    }
}
