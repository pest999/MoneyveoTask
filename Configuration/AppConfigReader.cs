using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Configuration
{
    public class AppConfigReader: IConfig
    {
        public string GetReportStorage()
        {
            return ConfigurationManager.AppSettings.Get("ReportStorage");
        }
        public int GetPageLoadTimeout()
        {
            string timeout = ConfigurationManager.AppSettings.Get("PageLoadTimeout");
            if (timeout == null)
                return 30;
            return Convert.ToInt32(timeout);
        }
    }
}
