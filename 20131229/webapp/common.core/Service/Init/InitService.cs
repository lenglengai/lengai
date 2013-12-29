namespace common.core
{
    public class InitService
    {
        public void _runPreinit(string nPath) {
            LogService loginService_ =
                __singleton<LogService>._instance();
            loginService_._runPreinit();
            SettingService settingService_ =
                __singleton<SettingService>._instance();
            settingService_._runPreinit(nPath);
        }

        public void _runInit() {

        }

        public _RunSlot m_tRunExit;
        public void _runExit() {
            this._runSave();
            if (null != m_tRunExit) {
                this.m_tRunExit();
            }
        }

        public _RunSlot m_tRunSave;
        public void _runSave() {
            if (null != m_tRunSave) {
                this.m_tRunSave();
            }
        }

        public InitService() {
            m_tRunExit = null;
            m_tRunSave = null;
        }
    }
}
