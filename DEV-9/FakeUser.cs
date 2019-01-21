using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DEV_9
{
    /// <summary>
    /// This class enters the page "vk" and displays unread messages.
    /// </summary>
    public class FakeUser
    {
        IWebDriver driver;
        IWebElement unreadMessage;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://vk.com/");

            driver.FindElement(By.XPath("//*[@id=\"index_email\"]")).SendKeys("+375259486802");
            driver.FindElement(By.XPath("//*[@id=\"index_pass\"]")).SendKeys("10111997abc" + Keys.Enter);

            driver.FindElement(By.XPath("//*[@id=\"l_msg\"]/a/span/span[3]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"ui_rmenu_unread\"]")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            unreadMessage = driver.FindElement(By.XPath("//*[@id=\"ui_rmenu_unread\"]/span/span"));
            Console.WriteLine(unreadMessage.Text);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}