using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace DemoAutomation
{
    public class TestBase
    {
        public string Url = "https://opensource-demo.orangehrmlive.com/index.php/auth/validateCredentials";
        public IActor Nami = new Actor(name: "Nami");

        [SetUp]
        public void SetUp()
        {
            var timon = new ChromeDriver();
            Nami.Can(BrowseTheWeb.With(timon));
        }
    }
}
