using TechTalk.SpecFlow;
using OpenQA.Selenium;
using POM;
using Utils;

namespace StepDefinitions
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

        [Given("User is on the SauceDemo login page")]
        public void GivenUserIsOnTheSauceDemoLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When("User enters valid username and password")]
        public void WhenUserEntersValidUsernameAndPassword()
        {
            _login.EnterUsername("standard_user");
            _login.EnterPassword("secret_sauce");
        }

        [When("User clicks on the login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            _login.ClickLoginButton();
        }

        [Then("User should be logged in successfully")]
        public void ThenUserShouldBeLoggedInSuccessfully()
        {
            Assert.IsTrue(_login.IsLoginSuccessful());
        }
    }
}