using TechTalk.SpecFlow;
using POM;
using Utils;

namespace SpecFlow.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly Login _login;

        public LoginStepDefinitions()
        {
            _login = new Login(WebDriverManager.Driver);
        }

        [Given("I navigate to '(.*)'")]
        public void GivenINavigateTo(string url)
        {
            WebDriverManager.Driver.Navigate().GoToUrl(url);
        }

        [When("I enter the username '(.*)' and password '(.*)'")]
        public void WhenIEnterTheUsernameAndPassword(string username, string password)
        {
            _login.EnterUsername(username);
            _login.EnterPassword(password);
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _login.ClickLoginButton();
        }

        [Then("I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            // Add verification steps for successful login
        }
    }
}