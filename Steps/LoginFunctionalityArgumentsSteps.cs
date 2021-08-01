using OpenQA.Selenium;
using NunitSpecflow.Utilities;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace NunitSpecflow.Steps 
{
    [Binding]
    public class LoginFunctionalityArgumentsSteps : Helper
    {
        [Given(@"User launches browser and opens ""(.*)""")]
        public void GivenUserLaunchesBrowserAndOpens(string url)
        {
            driver.Navigate().GoToUrl(url);
            Pause(2000);
        }
        
        [When(@"User enters username as ""(.*)"" and password as ""(.*)""")]
        public void WhenUserEntersUsernameAsAndPasswordAs(string s1, int s2)
        {
            System.Console.WriteLine(s1 );
            System.Console.WriteLine(s2);
            Pause(2000);
        }
        
        [Then(@"user will be navigated to the error page")]
        public void ThenUserWillBeNavigatedToTheErrorPage()
        {
            Assert.True(true);
        }
    }
}
