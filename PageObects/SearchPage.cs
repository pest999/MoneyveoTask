using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumTest.PageObects
{
    public class SearchPage : BasePage
    {
        [Obsolete]
        public SearchPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        #region Locators

        [FindsBy(How = How.XPath, Using = "//div[5]/div/div[1]/a/h3")]
        private IWebElement fourthItemInResults;

        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement InputSearchField;

        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement searchGoogleButton;

        #endregion

        #region
        public void SearchGoogle(string search)
        {
            InputSearchField.Clear();
            InputSearchField.SendKeys(search);
            Thread.Sleep(300);
        }

        public void ClickOnSearchButton()
        {
            searchGoogleButton.Click();
        }
        public override string FourthResult()
        {
            string text = fourthItemInResults.Text;
            return text;
        }

        #endregion
    }
}
