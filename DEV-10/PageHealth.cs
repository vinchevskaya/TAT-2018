using OpenQA.Selenium;

namespace DEV_10.Pages
{
    /// <summary>
    /// Сlass to test the health of all page functions.
    /// </summary>
    public class PageHealth
    {
        private IWebElement departureStation = Browser.Driver.FindElement(By.XPath("//*[@id=\"viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_: form1:textDepStat\"]"));

        private IWebElement arrivalStation = Browser.Driver.FindElement(By.XPath("//*[@id=\"viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_: form1:textArrStat\"]"));

        private IWebElement departureDate = Browser.Driver.FindElement(By.XPath("///*[@id=\"viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_: form1:dob\"]"));

        private IWebElement nextPage = Browser.Driver.FindElement(By.XPath("//*[@id=\"viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_: form1:buttonSearch\"]"));

        /// <summary>
        /// Go to trail page with valid data.
        /// </summary>
        public void MoveToNextPageWithValidData()
        {
            departureStation.SendKeys("МИНСК-ПАССАЖИРСКИЙ");
            arrivalStation.SendKeys("ГОМЕЛЬ");
            departureDate.SendKeys("16.01.2019");
            nextPage.Click();
        }

        /// <summary>
        /// Go to trail page when invalid data.
        /// </summary>
        public void MoveToNextPageWithUnValidData()
        {
            departureStation.SendKeys("МИНСК-ПАССАЖИРСКИЙ");
            arrivalStation.SendKeys("СЛУЦК");
            departureDate.SendKeys("23.12.2018");
            nextPage.Click();
        }
    }
}