using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace SeleniumTest.PageObects
{
    public class BasePage
    {
        private readonly IWebDriver driver = null;

        [Obsolete]
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public virtual string FourthResult()
        {
            string data=String.Empty;
            return data ;
        }
        
        public void NavigateToPage(string url)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can't navigate to url {0}", ex.Message);
            }
        }

        public virtual string GetText(IWebElement element)
        {
            return element.Text;
        }
        public bool IsElementPresent(By locator)
        {
            if (driver.FindElements(locator).Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
