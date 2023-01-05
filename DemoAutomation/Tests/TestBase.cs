using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Boa.Constrictor.RestSharp;
using RestSharp;

namespace DemoAutomation
{
    public class TestBase
    {
        public string Url = "https://www.saucedemo.com/";
        public IActor Nami = new Actor(name: "Nami");
        public string rutaDrivers = "C:/Users/Arbusta/Documents/Repositorios Git/QA automation/DemoAutomation-OrangeHRM/DemoAutomation/Drivers/";

        [OneTimeSetUp]
        public void SetUp()
        {
            var chrome = new ChromeDriver(rutaDrivers);
            Nami.Can(BrowseTheWeb.With(chrome));

        }
    }
}
