using System.Configuration;

namespace SeleniumTest.Configuration
{
    public class AppConfigReader : IConfig
    {
        public string GetReportStorage()
        {
            return ConfigurationManager.AppSettings.Get("ReportStorage");
        }
    }
}
