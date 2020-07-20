using log4net;
using log4net.Appender;
using log4net.Repository.Hierarchy;
using System;
using System.IO;

namespace SeleniumTest.Helpers
{
    public class LogHelper
    {
        private RollingFileAppender _rollingFileAppender;
        private Hierarchy _hierarchy;

        private static readonly ILog _log = LogManager.GetLogger(typeof(Logger));

        public LogHelper()
        {
            var log4NetConfig = new FileInfo("log4net.config");
            log4net.Config.XmlConfigurator.Configure(log4NetConfig);
            _hierarchy = (Hierarchy)LogManager.GetRepository();
            _rollingFileAppender = (RollingFileAppender)_hierarchy.Root.GetAppender("RollingAppender");
        }

        public void Debug(object message)
        {
            _log.Debug(message);
        }
        public void Info(object message)
        {
            _log.Info(message);
        }

        public void Info(object message, Exception exception)
        {
            _log.Info(message, exception);
        }
        public void Error(object message)
        {
            _log.Error(message);
        }
        public void Fatal(object message)
        {
            _log.Fatal(message);
        }
        public void Warn(object message)
        {
            _log.Warn(message);
        }

    }
}
