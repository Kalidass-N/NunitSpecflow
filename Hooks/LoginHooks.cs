using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using NunitSpecflow.Utilities;

namespace NunitSpecflow.Hooks
{
    [Binding]
    public class LoginHooks : Helper
    {
        
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
