using System.Collections.Generic;

using common.core;

namespace action.core
{
    public class ActionService
    {
        IActionHandle _getActionHandle(ulong nId) {
            IActionHandle result = null;
            if (mActionHandles.ContainsKey(nId)) {
                result = mActionHandles[nId];
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError =
                    string.Format(@"ActionService _getActionHandle:{0}",
                        nId);   
                logService_._logError(logError);
            }
            return result;
        }

        public void _register(IActionHandle nActionHandle) {
            ulong id_ = nActionHandle._getId();
            if (!mActionHandles.ContainsKey(id_)) {
                mActionHandles[id_] = nActionHandle;
            }  else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError =
                    string.Format(@"ActionService _register:{0}",
                        id_);
                logService_._logError(logError);
            }
        }

        public ActionService() {
            mActionHandles =
                new Dictionary<ulong, IActionHandle>();
        }

        Dictionary<ulong, IActionHandle> mActionHandles;
    }
}
