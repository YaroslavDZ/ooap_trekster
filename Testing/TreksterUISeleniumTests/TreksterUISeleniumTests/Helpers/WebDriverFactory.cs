using OpenQA.Selenium.Chrome;

namespace TreksterUISeleniumTests.Helpers
{
    public static class WebDriverFactory
    {
        public static ChromeDriver CreateDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("--headless=new");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument($"--user-data-dir=/tmp/chrome-user-data-{Guid.NewGuid()}");

            return new ChromeDriver(options);
        }
    }
}
