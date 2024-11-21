using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;

namespace Utilities.Utils
{
    public class SeleniumHelper
    {

        private IWebDriver driver;
        public IWebDriver InitializeDriver(string browserType)
        {
          
            switch (browserType)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;

                case "firefox":
                    driver = new FirefoxDriver();
                    break;

                case "edge":
                    driver = new EdgeDriver();
                    break;

                default:
                    throw new ArgumentException($"Brower not supported: {browserType}");
            }
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickElement(By by)
        {
            driver.FindElement(by).Click();
        }


        public IWebElement GetElement(By locator)
        {
            return driver.FindElement(locator);
        }


        public void CloseBrowser()
        {
            driver.Quit();
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

    }
}
