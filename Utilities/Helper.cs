using OpenQA.Selenium;

namespace NunitSpecflow.Utilities
{
    public class Helper
    {
        public static IWebDriver driver;

        public static void Pause(int time)
        {
            System.Threading.Thread.Sleep(time) ;
        }

    }
}
