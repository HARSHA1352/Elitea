using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;



namespace Utilities.Utils
{
    public class WebActions
    {
        readonly SeleniumHelper _seleniumHelper;

        public WebActions(SeleniumHelper seleniumHelper)
        {
            _seleniumHelper = seleniumHelper;
        }

        public void EnterText(By element, string text)
        {

            _seleniumHelper.GetDriver().FindElement(element).Clear();
            _seleniumHelper.GetDriver().FindElement(element).SendKeys(text);
        }

        public bool IsElementVisible(By by)
        {
            try
            {
                return _seleniumHelper.GetDriver().FindElement(by).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void TakeScreenshot(string filename)
        {
            Screenshot ss = ((ITakesScreenshot)_seleniumHelper.GetDriver()).GetScreenshot();
            string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Screenshots");
            Directory.CreateDirectory(directory); // Ensure the directory exists
            string filePath = Path.Combine(directory, filename);
            if (!filePath.EndsWith(".png"))
            {
                filePath += ".png";
            }
            ss.SaveAsFile(filePath);
        }


    }

}
