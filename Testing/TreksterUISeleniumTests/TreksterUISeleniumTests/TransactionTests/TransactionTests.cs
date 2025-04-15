using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace TreksterUISeleniumTests.TransactionTests
{
    public class TransactionTests
    {
        [Fact]
        public void CreateTransaction_WithValidData_ShouldRedirectToHome()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            using var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            driver.Navigate().GoToUrl("https://localhost:7034/User/Login");
            driver.FindElement(By.Name("Email")).SendKeys("YourLogin");
            driver.FindElement(By.Name("Password")).SendKeys("YourPassword");
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            wait.Until(ExpectedConditions.UrlContains("/Home/Index"));

            driver.Navigate().GoToUrl("https://localhost:7034/Home/CreateTransaction");

            var accountSelect = new SelectElement(driver.FindElement(By.Name("AccountsAndCurency")));
            accountSelect.SelectByIndex(0);

            var categorySelect = new SelectElement(driver.FindElement(By.Name("CategoryId")));
            categorySelect.SelectByIndex(1);

            var sumInput = driver.FindElement(By.Name("Sum"));
            sumInput.Clear();
            sumInput.SendKeys("150");

            var submitButton = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[type='submit']")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", submitButton);

            wait.Until(ExpectedConditions.UrlContains("/Home/Index"));

            Assert.Contains("/Home/Index", driver.Url);
        }
    }
}
