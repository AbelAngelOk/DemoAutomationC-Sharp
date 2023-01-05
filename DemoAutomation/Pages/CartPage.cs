using Boa.Constrictor.WebDriver;
using static Boa.Constrictor.WebDriver.WebLocator;
using OpenQA.Selenium;

namespace DemoAutomation.Pages
{
    internal class CartPage
    {
        public static IWebLocator LblCartItem => L("el logo del carrito de compras", By.ClassName("cart_item"));
        public static IWebLocator BtnRemoveItem => L("los botones genericos para remover un item", By.XPath("//button[contains(.,'Remove')]"));
        public static IWebLocator BtnContinueShopping => L("el boton para volver a /inventory", By.Id("continue-shopping"));
    }
}
