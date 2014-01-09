using System.Collections.Generic;

namespace common.core
{
    public class ActionService
    {
        public void _sendAction(Action nAction) {
            uint actionType = nAction._getActionType();
            uint actionCount = nAction._getActionCount();
            __tuple<uint, uint> tuple_ =
                this._serverHandle(actionType, actionCount);
            if (null == tuple_) return;
            SettingService settingService_ =
                __singleton<SettingService>._instance();
            if (settingService_._checkServerId(tuple_._get_0())) {
                HandleService handleService =
                    __singleton<HandleService>._instance();
                handleService._addActionHeader
                    (tuple_._get_1(), nAction._getAtionHeader());
            } else {
            }
        }

        public void _addServerHandle
            (uint nType, _ServerHandle nServerHandle) 
        {
            if (mServerHandles.ContainsKey(nType)) {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_addServerHandle:{0}", nType);
                logService_._logError(TAG, logError);
            } else {
                mServerHandles[nType] = nServerHandle;
            }
        }

        __tuple<uint, uint> _serverHandle(uint nType, uint nCount) {
            if (mServerHandles.ContainsKey(nType)) {
                _ServerHandle serverHandle = mServerHandles[nType];
                return serverHandle(nCount);
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_serverHandle:{0}", nType);
                logService_._logError(TAG, logError);
            }
            return null;
        }

        public void _runPreinit() {

        }

        public ActionService() {
            mServerHandles = new Dictionary<uint, _ServerHandle>();
        }

        Dictionary<uint, _ServerHandle> mServerHandles;
        const string TAG = "ActionService";
    }
}
