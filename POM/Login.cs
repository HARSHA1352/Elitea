using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM
{
    public class Login
    {
        public void EnterUsername(string username)
        {
            _driver.FindElement(usernameInput).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(passwordInput).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(loginBtn).Click();
        }

        public bool IsLoginSuccessful()
        {
            return _driver.FindElement(productTitle).Displayed;
        }

    }
}
