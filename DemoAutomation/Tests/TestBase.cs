using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace DemoAutomation
{
    public class TestBase
    {
        public string Url = "https://opensource-demo.orangehrmlive.com/";
        public IActor Nami = new Actor(name: "Nami");
        public string rutaDrivers = "C:/Users/Arbusta/Documents/Repositorios Git/QA automation/DemoAutomation-OrangeHRM/DemoAutomation/Drivers/";

        [SetUp]
        public void SetUp()
        {
            var chrome = new ChromeDriver(rutaDrivers);
            Nami.Can(BrowseTheWeb.With(chrome));
        }
    }
}
