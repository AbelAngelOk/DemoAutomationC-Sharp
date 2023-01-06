using Boa.Constrictor.WebDriver;
using static Boa.Constrictor.WebDriver.WebLocator;
using OpenQA.Selenium;

namespace DemoAutomation.Pages
{
    internal class InventoryPage
    {
        public static IWebLocator LogoShoppingCart => L("el logo del carrito de compras", By.Id("shopping_cart_container"));
        public static IWebLocator BtnAddToCard_BikeLight => L("el boton agregar al carrito de compras del producto Bike Light", By.Id("add-to-cart-sauce-labs-bike-light"));

        public static IWebLocator BtnAddToCard_Backpack = L("el boton agregar al carrito de compras del producto Back Pack", By.Id("add-to-cart-sauce-labs-backpack"));
    }
}
