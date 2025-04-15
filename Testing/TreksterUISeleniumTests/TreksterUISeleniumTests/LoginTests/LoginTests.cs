using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TreksterUISeleniumTests.LoginTests
{
    public class LoginTests
    {
        [Fact]
        public void Login_WithEmptyFields_ShouldShowRequiredFieldValidation()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            using var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://localhost:7034/");

            driver.FindElement(By.Name("Email")).Clear();
            driver.FindElement(By.Name("Password")).Clear();
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            var validation = wait.Until(drv =>
                drv.FindElements(By.ClassName("text-danger"))
                    .FirstOrDefault(e => e.Displayed && e.Text.Contains("The Email field is required.")));

            Assert.NotNull(validation);
        }

        [Fact]
        public void Login_WithInvalidEmailFormat_ShouldShowHtml5ValidationError()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            using var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://localhost:7034/");

            var emailInput = driver.FindElement(By.Name("Email"));
            var passwordInput = driver.FindElement(By.Name("Password"));
            var loginButton = driver.FindElement(By.CssSelector("button[type='submit']"));

            emailInput.SendKeys("invalidemail");
            passwordInput.SendKeys("SomePassword");

            loginButton.Click();

            var validationMessage = ((IJavaScriptExecutor)driver)
                .ExecuteScript("return arguments[0].validationMessage;", emailInput) as string;

            Assert.Contains("Please include an '@'", validationMessage);
        }

        [Fact]
        public void Login_WithWrongPassword_ShouldShowInvalidLoginMessage()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            using var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://localhost:7034/");

            driver.FindElement(By.Name("Email")).SendKeys("user@example.com");
            driver.FindElement(By.Name("Password")).SendKeys("wrongpassword123");
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            var errorContainer = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("validation-summary-errors")));
            Assert.Contains("Invalid UserName or Password", errorContainer.Text);
        }

        [Fact]
        public void Login_WithValidCredentials_ShouldRedirectToHome()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            using var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://localhost:7034/");

            var emailInput = driver.FindElement(By.Name("Email"));
            var passwordInput = driver.FindElement(By.Name("Password"));
            var loginButton = driver.FindElement(By.CssSelector("button[type='submit']"));

            emailInput.SendKeys("YourLogin");
            passwordInput.SendKeys("YourPassword");

            loginButton.Click();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.TitleContains("Головна"));

            Assert.Contains("Головна", driver.Title);
        }
    }
}
