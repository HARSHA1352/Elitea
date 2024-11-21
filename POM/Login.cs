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
        private By usernameInput => By.Id("user-name");

        private By passwordInput => By.Id("password");

        private By loginBtn => By.Id("login-button");

        private By errorMsg => By.XPath("//div[@class='error-message-container error']");

        public By productTitle => By.XPath("//span[@class='title']");

    }
}
