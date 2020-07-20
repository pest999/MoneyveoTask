using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Configuration
{
    public interface IConfig
    {
        string GetReportStorage();
        int GetPageLoadTimeout();
    }
}
