using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using TreksterUISeleniumTests.Helpers;

namespace TreksterUISeleniumTests.CategoryTests
{
    public class CategoryTests
    {
        private readonly string BaseUrl = "http://localhost:7034";
        private readonly string Email = "test@user.com";
        private readonly string Password = "Test123!";

        [Fact(DisplayName = "Category Сreate Test")]
        public void CreateEditDelete_Category_Lifecycle()
        {
            var createdCategoryName = "TestCat_" + Guid.NewGuid().ToString("N").Substring(0, 5);
            var updatedCategoryName = createdCategoryName + "_Updated";

            using var driver = InitDriver();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Login(driver, wait);

            // === CREATE ===
            driver.Navigate().GoToUrl($"{BaseUrl}/Settings/Categories");
            var addCategoryButton = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.CssSelector("a.btn-info[href='/Settings/Create']")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", addCategoryButton);
            addCategoryButton.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("Name")));
            driver.FindElement(By.Name("Name")).SendKeys(createdCategoryName);
            driver.FindElement(By.CssSelector("input[type='radio'][value='1']")).Click();
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();

            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("a.btn-info[href='/Settings/Create']")));
            Assert.Contains(createdCategoryName, driver.FindElement(By.TagName("body")).Text);
        }

        private IWebDriver InitDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
			var driver = WebDriverFactory.CreateDriver();
			driver.Manage().Window.Maximize();
            return driver;
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