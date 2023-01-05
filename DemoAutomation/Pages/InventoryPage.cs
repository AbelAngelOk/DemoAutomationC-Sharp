using Boa.Constrictor.WebDriver;
using static Boa.Constrictor.WebDriver.WebLocator;
using OpenQA.Selenium;

namespace DemoAutomation.Pages
{
    internal class InventoryPage
    {
        public static IWebLocator LogoShoppingCart => L("el logo del carrito de compras", By.Id("shopping_cart_container"));
        public static IWebLocator BtnAddToCard_BikeLight => L("", By.Id("add-to-cart-sauce-labs-bike-light"));

        public static IWebLocator BtnAddToCard_Backpack = L("", By.Id("add-to-cart-sauce-labs-backpack"));
    }
}
