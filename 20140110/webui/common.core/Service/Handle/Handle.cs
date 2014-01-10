using System.Threading;
using System.Collections.Generic;

namespace common.core
{
    public class Handle
    {
        public void _runHandle() {
        }

        public void _initContext(IContextId nContextId) {
            uint contextId_ = nContextId._getContextId();
            if (mContexts.ContainsKey(contextId_)) {
                LogService logService_ = __singleton<LogService>._instance();
                string logError = string.Format(@"_initContext:{0}", contextId_);
                logService_._logError(TAG, logError);
            } else {
                Context context_ = nContextId._createContext();
                context_._setHandle(this);
                mContexts[contextId_] = context_;
            }
        }

        public Handle(uint nIndex, uint nType) {
            mContexts = new Dictionary<uint, Context>();
            mIndex = nIndex;
            mType = nType;
        }

        Dictionary<uint, Context> mContexts;
        const string TAG = "Handle";
        uint mIndex;
        uint mType;
    }
}
