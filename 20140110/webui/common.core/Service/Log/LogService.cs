using log4net;

namespace common.core
{
    public class LogService
    {
        public void _logFatal(string nValue)
        {
            mLog.Fatal(nValue);
        }

        public void _logError(string nValue)
        {
            mLog.Error(nValue);
        }

        public void _logWarn(string nValue)
        {
            mLog.Warn(nValue);
        }

        public void _logMsg(string nValue)
        {
            mLog.Info(nValue);
        }

        public void _logFatal(string nClass, string nValue)
        {
            string logError = string.Format
                (@"[{0}]{1}", nClass, nValue);
            mLog.Fatal(logError);
        }

        public void _logError(string nClass, string nValue)
        {
            string logError = string.Format
                (@"[{0}]{2}", nClass, nValue);
            mLog.Error(logError);
        }

        public void _logWarn(string nClass, string nValue)
        {
            string logError = string.Format
                (@"[{0}]{1}", nClass, nValue);
            mLog.Warn(logError);
        }

        public void _logMsg(string nClass, string nValue)
        {
            string logInfo = string.Format
                (@"[{0}]{1}", nClass, nValue);
            mLog.Info(logInfo);
        }

        public void _runPreinit() {
            mLog = LogManager.GetLogger("log");
        }

        public LogService() {
            mLog = null;
        }

        ILog mLog;
    }
}
