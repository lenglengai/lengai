using log4net;

namespace common.core
{
    public class LogService
    {
        public void _logFatal(string nValue) {
            mLog.Fatal(nValue);
        }

        public void _logError(string nValue) {
            mLog.Error(nValue);
        }

        public void _logWarn(string nValue) {
            mLog.Warn(nValue);
        }

        public void _logMsg(string nValue) {
            mLog.Info(nValue);
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
