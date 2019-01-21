using OpenQA.Selenium;

namespace DEV_10.Pages
{
    /// <summary>
    /// Class to enter the site.
    /// </summary>
    public class LoginPage
    {
        private IWebElement openTheSite = Browser.Driver.FindElement(By.XPath("//*[@id=\"top\"]"));
        private IWebElement login = Browser.Driver.FindElement(By.XPath("//*[@id=\"login\"]"));
        private IWebElement password = Browser.Driver.FindElement(By.XPath("//*[@id=\"password\"]"));
        private IWebElement inputButton = Browser.Driver.FindElement(By.XPath("//*[@class=\"commandExButton\"]"));
        private IWebElement confirmButton = Browser.Driver.FindElement(By.XPath("//*[@id=\"viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_: form1:conf\"]"));

        public void Search()
        {
            openTheSite.Click();
            login.SendKeys("winchewskaja");
            password.SendKeys("mopidu93");
            inputButton.Click();
            confirmButton.Click();
        }
    }    
}