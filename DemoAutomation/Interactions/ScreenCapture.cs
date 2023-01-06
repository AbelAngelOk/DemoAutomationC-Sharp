using Boa.Constrictor.Screenplay;
using OpenQA.Selenium;

namespace DemoAutomation.Interactions
{
    /// <summary>
    /// Proposito: Toma una captura de pantalla del error.
    /// </summary>
    internal class ScreenCaptureTask : TestBase, ITask
    {
        /// <summary>
        /// Proposito: Toma una captura de pantalla del error.
        /// </summary>
        public static ScreenCaptureTask OfFail() => new ScreenCaptureTask();

        public void PerformAs(IActor actor)
        {
            Screenshot captura = chrome.GetScreenshot();
            captura.SaveAsFile("Captura.PNG");
        }
    }
}
