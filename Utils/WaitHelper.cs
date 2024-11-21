using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;

namespace Utilities.Utils
{
    public class WaitHelper
    {
        private readonly SeleniumHelper _seleniumHelper;
        public WaitHelper(SeleniumHelper seleniumHelper)
        {
            _seleniumHelper = seleniumHelper;
        }
        public void CollectiveWait(int time)
        {
            _seleniumHelper.GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
        }

        public void WaitForCondition(By locator, int time)
        {
            WebDriverWait wait = new WebDriverWait(_seleniumHelper.GetDriver(), TimeSpan.FromSeconds(time));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));

        }
        
    }
}
