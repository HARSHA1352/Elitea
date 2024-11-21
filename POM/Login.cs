using OpenQA.Selenium;
using Utils;

namespace POM
{
    public class Login
    {
        private readonly IWebDriver _driver;

        public Login(IWebDriver driver)
        {
            _driver = driver;
        }

        public void EnterUsername(string username)
        {
            _driver.FindElement(By.Id("user-name")).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(By.Id("password")).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(By.CssSelector("input.btn_action")).Click();
        }
    }
}
