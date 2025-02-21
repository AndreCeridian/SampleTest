namespace XUnitTestProject
{
    public class UnitTest1
    {
        protected RemoteWebDriver driver;

        public UnitTest1()
        {
            DriverOptions capabilities = new ChromeOptions();
            capabilities.BrowserVersion = "latest";

            driver = new RemoteWebDriver(new Uri("http://hub.browserstack.com/wd/hub/"), capabilities);
        }

        [Fact]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.dayforce.com");

            Assert.Contains("Dayforce", driver.Title);
        }

        public void Dispose()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}