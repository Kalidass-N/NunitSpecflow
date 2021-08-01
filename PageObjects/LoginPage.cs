using OpenQA.Selenium;
using NunitSpecflow.Utilities;

namespace NunitSpecflow.PageObjects
{
    public class LoginPage : Helper
    {
        public static LoginPage lp = null;
        public static LoginPage Init
        {
            get
            {
                if (lp == null)
                {
                    lp = new LoginPage();
                }
                return lp;
            }
        }

        IWebElement username => driver.FindElement(By.Id("Username"));
        IWebElement password => driver.FindElement(By.Id("Password"));
        IWebElement loginBtn => driver.FindElement(By.XPath("login"));

        public void SetUserName(string name) 
        {
            username.SendKeys(name);
        }
        public void SetPassword(string pass)
        {
            password.SendKeys(pass);
        }
        public void ClickButton()
        {
            loginBtn.Click();
        }
    }
}
