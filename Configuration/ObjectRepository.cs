using OpenQA.Selenium;

namespace SeleniumTest.Configuration
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
    }
}
