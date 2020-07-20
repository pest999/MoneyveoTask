using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Helpers
{
    public class Utils
    {
        private IWebDriver Driver { get; }
        public Utils(IWebDriver driver)
        {
            Driver = driver;
        }

        public string GetText(IWebElement element)
        {
            return element.Text;
        }
        public bool IsValuePresentInResult(string result, string template)
        {
            bool value = result.Contains(template);

            return value;
        }
    }
}
