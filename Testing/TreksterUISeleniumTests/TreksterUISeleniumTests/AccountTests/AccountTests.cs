using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TreksterUISeleniumTests.Helpers;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace TreksterUISeleniumTests.AccountTests
{
    [TestCaseOrderer("TreksterUISeleniumTests.Helpers.PriorityOrderer", "TreksterUISeleniumTests")]
    public class AccountTests
    {
        private const string BaseUrl = "https://localhost:7034";
        private const string Email = "test@user.com";
        private const string Password = "Test123!";
        private static string _createdAccountName = string.Empty;

        [Fact, TestPriority(1)]
        public void CreateAccount_WithValidData_ShouldAppearInList()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
			using var driver = WebDriverFactory.CreateDriver();
			driver.Manage().Window.Maximize();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Login(driver, wait);

            driver.Navigate().GoToUrl($"{BaseUrl}/Accounts/Create");

            _createdAccountName = "TestAcc_" + Guid.NewGuid().ToString("N").Substring(0, 5);
            driver.FindElement(By.Name("Name")).SendKeys(_createdAccountName);

            driver.FindElement(By.Name("StartBalances[Uah]")).SendKeys("123");
            driver.FindElement(By.Name("StartBalances[Usd]")).SendKeys("234");
            driver.FindElement(By.Name("StartBalances[Eur]")).SendKeys("345");
            driver.FindElement(By.Name("StartBalances[Usdt]")).SendKeys("456");
            driver.FindElement(By.Name("StartBalances[Btc]")).SendKeys("5");

            driver.FindElement(By.Name("Name")).SendKeys(_createdAccountName + Keys.Tab);

            var submitButton = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[type='submit']")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", submitButton);

            wait.Until(ExpectedConditions.UrlContains("/Accounts/Index"));

            var accountDivs = driver.FindElements(By.ClassName("info-container"));
            Assert.Contains(accountDivs, div => div.Text.Contains(_createdAccountName));
        }

        [Fact, TestPriority(2)]
        public void Delete_Account_ByName_ShouldSucceed()
        {
            Assert.False(string.IsNullOrEmpty(_createdAccountName), "Account name is not set from previous test.");

            new DriverManager().SetUpDriver(new ChromeConfig());
            using var driver = WebDriverFactory.CreateDriver();
            driver.Manage().Window.Maximize();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Login(driver, wait);

            driver.Navigate().GoToUrl($"{BaseUrl}/Settings/Accounts");

            var deleteButtons = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(
                By.CssSelector("a.btn-danger")));

            IWebElement? targetDeleteButton = null;

            foreach (var btn in deleteButtons)
            {
                try
                {
                    var label = btn.FindElement(By.XPath("../../div[1]"));
                    if (label.Text.Contains(_createdAccountName))
                    {
                        targetDeleteButton = btn;
                        break;
                    }
                }
                catch { /* пропустити */ }
            }

            Assert.NotNull(targetDeleteButton);

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", targetDeleteButton);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", targetDeleteButton);

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[type='submit'].btn-danger")));
            Assert.Contains(_createdAccountName, driver.FindElement(By.TagName("body")).Text);

            driver.FindElement(By.CssSelector("input[type='submit'].btn-danger")).Click();
            wait.Until(ExpectedConditions.UrlContains("/Settings/Accounts"));

            Assert.DoesNotContain(_createdAccountName, driver.PageSource);
        }

        private void Login(IWebDriver driver, WebDriverWait wait)
        {
            driver.Navigate().GoToUrl($"{BaseUrl}/User/Login");
            driver.FindElement(By.Name("Email")).SendKeys(Email);
            driver.FindElement(By.Name("Password")).SendKeys(Password);
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            wait.Until(ExpectedConditions.UrlContains("/Home/Index"));
        }
    }
}
