namespace XUnitTestProject
{
    public class UnitTest1 : IDisposable
    {
        protected RemoteWebDriver driver;

        public UnitTest1()
        {
            DriverOptions capabilities = new ChromeOptions();

            driver = new RemoteWebDriver(new Uri("http://hub.browserstack.com/wd/hub/"), capabilities);
        }

        [Fact]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.dayforce.com");

            if (driver.Url.Contains("appium.io"))
            {
                driver.Navigate().GoToUrl("https://www.dayforce.com");
            }

            Assert.Contains("Dayforce", driver.Title);
        }

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Quit();
                if (driver is IDisposable disposable)
                {
                    disposable.Dispose();
                }
            }
        }
    }
}