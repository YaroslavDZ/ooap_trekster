using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using TreksterUISeleniumTests.Helpers;

namespace TreksterUISeleniumTests.TransactionTests
{
    public class TransactionTests
    {
		private readonly string BaseUrl = "http://localhost:7034";
		private static string _createdAccountName = string.Empty;

		[Fact]
        public void CreateTransaction_WithValidData_ShouldRedirectToHome()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            using var driver = WebDriverFactory.CreateDriver();
            driver.Manage().Window.Maximize();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            driver.Navigate().GoToUrl("http://localhost:7034/User/Login");
            driver.FindElement(By.Name("Email")).SendKeys("test@user.com");
            driver.FindElement(By.Name("Password")).SendKeys("Test123!");
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            wait.Until(ExpectedConditions.UrlContains("/Home/Index"));

			driver.Navigate().GoToUrl($"{BaseUrl}/Accounts/Create");

			_createdAccountName = "TestAcc_" + Guid.NewGuid().ToString("N").Substring(0, 5);
			driver.FindElement(By.Name("Name")).SendKeys(_createdAccountName);

			driver.FindElement(By.Name("StartBalances[Uah]")).SendKeys("123");
			driver.FindElement(By.Name("StartBalances[Usd]")).SendKeys("234");
			driver.FindElement(By.Name("StartBalances[Eur]")).SendKeys("345");
			driver.FindElement(By.Name("StartBalances[Usdt]")).SendKeys("456");
			driver.FindElement(By.Name("StartBalances[Btc]")).SendKeys("5");

			driver.FindElement(By.Name("Name")).SendKeys(_createdAccountName + Keys.Tab);

			var submitButtonFirst = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[type='submit']")));
			((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", submitButtonFirst);

			wait.Until(ExpectedConditions.UrlContains("/Accounts/Index"));

			driver.Navigate().GoToUrl("http://localhost:7034/Home/CreateTransaction");

            var accountSelect = new SelectElement(driver.FindElement(By.Name("AccountsAndCurency")));
            accountSelect.SelectByIndex(0);

            var categorySelect = new SelectElement(driver.FindElement(By.Name("CategoryId")));
            categorySelect.SelectByIndex(1);

            var sumInput = driver.FindElement(By.Name("Sum"));
            sumInput.Clear();
            sumInput.SendKeys("150");

            var submitButtonSecond = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[type='submit']")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", submitButtonSecond);

            wait.Until(ExpectedConditions.UrlContains("/Home/Index"));

            Assert.Contains("/Home/Index", driver.Url);
        }
    }
}
