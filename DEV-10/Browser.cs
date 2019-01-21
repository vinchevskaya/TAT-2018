using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace DEV_10
{
    public static class Browser
    {
        public static IWebDriver Driver { get; set; }
        public static bool Initialised { get; set; }

        public static void Initialize()
        {            
            Driver = new ChromeDriver(@"C:\Program Files (x86)\Google\Chrome\Application");
            Initialised = true;
        }

        public static void Quit()
        {
            Driver.Quit();
            Initialised = false;
        }
    }
}