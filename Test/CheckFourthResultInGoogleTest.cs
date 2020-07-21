using NUnit.Framework;
using SeleniumTest.Helpers;
using SeleniumTest.PageObects;

namespace SeleniumTest.Test
{
    [TestFixture]
    class CheckFourthResultInGoogleTest : BaseTest
    {
        private static LogHelper log = new LogHelper();
        BasePage basePage = null;
        SearchPage searchPage = null;
        Utils utils = null;

        [SetUp]
        public void Setup()
        {
            basePage = new BasePage(driver);
            searchPage = new SearchPage(driver);
            utils = new Utils(driver);
            basePage.NavigateToPage(TestData.UrlTo_Test1);
        }

        [Test]
        [Description("Search 'Selenium IDE' in results 'Selenium IDE export to C#' in google")]
        [Author("Kvashnin Artem")]
        public void CheckResultInSearching()
        {
            log.Info("Start testcase");
            searchPage.SearchGoogle(TestData.DataToSearch_Test1);
            searchPage.ClickOnSearchButton();
            var result = searchPage.FourthResult();
            Assert.True(utils.IsValuePresentInResult(result, TestData.ExpectedResult1_Test1));
            log.Info("Finish testcase");
        }
    }
}
