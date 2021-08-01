using NUnit.Framework;
using NunitSpecflow.PageObjects;
using TechTalk.SpecFlow;
using NunitSpecflow.Utilities;

namespace NunitSpecflow.Steps

{
    [Binding]
    public class LoginFunctionalityOfPluralsightSteps : Helper
    {
        LoginPage lpage;
        [Given(@"User launches browser and opens plural sight application")]
        public void GivenUserLaunchesBrowserAndOpensPluralSightApplication()
        {
            driver.Navigate().GoToUrl("https://app.pluralsight.com/id");
            Pause(2000);
        }
        
        [When(@"User enters invalid credentials")]
        public void WhenUserEntersInvalidCredentials()
        {
            lpage = new LoginPage();
            lpage.SetUserName("Kalidass");
            lpage.SetPassword("12345678");
            Pause(2000);
        }
        
        [Then(@"user should not navigated to the home page")]
        public void ThenUserShouldNotNavigatedToTheHomePage()
        {

            Assert.That(driver.Title, Is.EqualTo("Sign In | Pluralsight")) ;
            Pause(2000);
        }
    }
}
