using TechTalk.SpecFlow;
using OpenQA.Selenium;
using POM;
using Utils;

namespace Elitea.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly Login _login;

        public LoginStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
            _login = new Login(_driver);
        }

        [Given("I am on the SauceDemo login page")]
        public void GivenIAmOnTheSauceDemoLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When("I enter valid username and password")]
        public void WhenIEnterValidUsernameAndPassword()
        {
            _login.EnterUsername("standard_user");
            _login.EnterPassword("secret_sauce");
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _login.ClickLoginButton();
        }

        [Then("I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            // Add assertion for successful login
        }
    }
}