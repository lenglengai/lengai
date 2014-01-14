namespace common.core
{
    public class InitService
    {
        public void _runPreinit(string nPath) {
            if (mPreinited) return;
            LogService loginService_ = __singleton<LogService>._instance();
            loginService_._runPreinit();
            SettingService settingService_ = __singleton<SettingService>._instance();
            settingService_._runPreinit(nPath);
            SqlService sqlService = __singleton<SqlService>._instance();
            sqlService._runPreinit();
            HandleService handleService_ = __singleton<HandleService>._instance();
            handleService_._runPreinit();
            mPreinited = true;
        }

        public _RunSlot m_tRunInit;
        public void _runInit() {
            if (mInited) return;
            if (null != m_tRunInit) {
                this.m_tRunInit();
            }
            mInited = true;
        }

        public _RunSlot m_tRunStart;
        public void _runStart() {
            if (mStarted) return;
            if (null != m_tRunStart) {
                this.m_tRunStart();
            }
            mStarted = true;
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
            mPreinited = false;
            mInited = false;
            mStarted = false;
            m_tRunExit = null;
            m_tRunSave = null;
            m_tRunInit = null;
            m_tRunStart = null;
        }

        bool mPreinited;
        bool mInited;
        bool mStarted;
    }
}
