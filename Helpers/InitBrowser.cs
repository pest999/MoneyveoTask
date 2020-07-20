using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;

namespace SeleniumTest.Helpers
{
    public class InitBrowser
    {
        private static WebDriverWait browserWait;
        private static IWebDriver driver;
        public static ExtentReports report;
        public static ExtentTest test;

        public static IWebDriver Driver
        {
            get => driver;
            set
            {
                if (value == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized");
                else
                    driver = value;
            }
        }

        public static WebDriverWait BrowserWait { get => browserWait; set => browserWait = value; }

        public IWebDriver GetDriver()
        {
            driver = new ChromeDriver(Directory.GetCurrentDirectory());
            driver.Manage().Window.Maximize();
            BrowserWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            return driver;
        }

        public void CloseBrowser()
        {
            try
            {
                if (driver != null)
                {
                    driver.Quit();
                    driver = null;
                    BrowserWait = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Browser didn't close - {0}", ex.StackTrace);
            }
        }
    }
}
