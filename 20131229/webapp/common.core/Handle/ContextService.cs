using System.Collections.Generic;

namespace common.core
{
    public class ContextService
    {
        public void _registerContextId(IContextId nContextId) {
            uint contextId_ = nContextId._getContextId();
            if (mContextIds.ContainsKey(contextId_)) {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_registerPropertyId:{0}", contextId_);
                logService_._logError(TAG, logError);
            } else {
                mContextIds[contextId_] = nContextId;
            }
        }

        public IContextId _getContextId(uint nContextId) {
            IContextId result_ = null;
            if (mContextIds.ContainsKey(nContextId)) {
                result_ = mContextIds[nContextId];
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_getContextId:{0}", nContextId);
                logService_._logError(TAG, logError);
            }
            return result_;
        }

        public ContextService() {
            mContextIds = new Dictionary<uint, IContextId>();
        }

        Dictionary<uint, IContextId> mContextIds;
        const string TAG = "ContextService";
    }
}
