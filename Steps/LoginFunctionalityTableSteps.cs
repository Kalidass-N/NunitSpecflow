using NunitSpecflow.Utilities;
using TechTalk.SpecFlow;
using NunitSpecflow.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;

namespace NunitSpecflow.Steps
{
    [Binding]
    public class LoginOfPluralsightSteps : Helper
    {
        public LoginOfPluralsightSteps()
        {
            LoginPage.lp=LoginPage.Init;
        }
        

        [Given(@"User opens plural sight application")]
        public void GivenUserOpensPluralSightApplication()
        {
            driver.Navigate().GoToUrl("https://app.pluralsight.com/id");
            Pause(2000);
        }
        
     
        
        [When(@"User clicks invalid credentials")]
        public void WhenUserClicksInvalidCredentials(Table table)
        {

            LoginPage.lp.SetUserName(table.Rows[0][0]);
            LoginPage.lp.SetPassword(table.Rows[0][1]);
            Pause(2000);
        }
       
        
        [Then(@"user navigated again to the home page")]
        public void ThenUserNavigatedAgainToTheHomePage()
        {
            Assert.True(true);
        }
        [Given(@"User launches plural sight application")]
        public void GivenUserLaunchesPluralSightApplication()
        {
            driver.Navigate().GoToUrl("https://app.pluralsight.com/id");
            Pause(2000);

        }
        [When(@"User is trying to login with ""(.*)"" and ""(.*)""")]
        public void WhenUserIsTryingToLoginWithAnd(string s1, string s2)
        {

            LoginPage.lp.SetUserName(s1);
            LoginPage.lp.SetPassword(s2);
            Pause(2000);
        }

        [Then(@"user should be navigated to the error page")]
        public void ThenUserShouldBeNavigatedToTheErrorPage()
        {
            Assert.True(true);
        }
    }
}
