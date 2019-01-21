using NUnit.Framework;

namespace DEV_10.Pages
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Before()
        {
            if (!Browser.Initialised) Browser.Initialize();
            Browser.Driver.Navigate().GoToUrl("https://poezd.rw.by/");
        }

        [TearDown]
        public void After()
        {
            Browser.Quit();
        }

        [Test]
        public void Test()
        {
            Pages.LoginPage.Search();
            Pages.PageHealth.MoveToNextPageWithValidData();
            Pages.PageHealth.MoveToNextPageWithUnValidData();
        }
    }
}