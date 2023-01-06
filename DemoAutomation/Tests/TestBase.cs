using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework.Interfaces;


namespace DemoAutomation
{
    public class TestBase
    {
        public string Url = "https://www.saucedemo.com/";
        public IActor Nami = new Actor(name: "Nami"); 
        public string rutaDrivers = "C:/Users/Arbusta/Documents/Repositorios Git/QA automation/DemoAutomation-OrangeHRM/DemoAutomation/Drivers/";

        public ChromeDriver chrome;
        
        [OneTimeSetUp]
        public void SetUp()
        {
            chrome = new ChromeDriver(rutaDrivers);
            Nami.Can(BrowseTheWeb.With(chrome));
        }

        [OneTimeTearDown] /* capturas de pantalla en implementacion, no funciona */
        public void ScreenCaptureOfFail()
        {
            string nameTest = TestContext.CurrentContext.Test.FullName.Normalize();

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {               
                Screenshot captura = chrome.GetScreenshot();
                string ruta = "C:/Users/Arbusta/Documents/Repositorios Git/QA automation/DemoAutomation-OrangeHRM/DemoAutomation/Screenshot";
                captura.SaveAsFile(ruta + nameTest + ".PNG");

            }
        }
        
    }
}
