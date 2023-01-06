using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using DemoAutomation.Interactions;
using DemoAutomation.Models;
using DemoAutomation.Pages;
using NUnit.Framework;

namespace DemoAutomation.Tests
{
    [TestFixture]
    internal class AddProductsToShoppingCart : TestBase
    {
        [SetUp]
        public void EmptyShoppingCart ()
        {
            Nami.AttemptsTo(Navigate.ToUrl(Url));
            Nami.AttemptsTo(WaitForTheElementsToLoad.OfLoginPage());
            Nami.AttemptsTo(LogIn.With( User.StandardUser() ));
            Nami.AttemptsTo(EmptyThatShoppingCart.IfItHaveAProduct() );
        }

        [Test]
        public void AddAProductToCart ()
        {
            Nami.AttemptsTo(AddToShoppingCart.OneProduct());
            Nami.AskingFor(IsInCart.OneProduct());
        }

        [Test]
        public void AddMoreThanOneProductoCart ()
        {
            Nami.AttemptsTo(AddToShoppingCart.TwoProducts());
            Nami.AskingFor(IsInCart.TheProducts(2));
        }
    }
}
