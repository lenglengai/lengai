using System.Collections.Generic;

namespace common.core
{
    public class Handle
    {
        public void _initContext(IContextId nContextId) {
            uint contextId_ = nContextId._getContextId();
            if (mContexts.ContainsKey(contextId_)) {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_initContext:{0}", contextId_);
                logService_._logError(TAG, logError);
            } else {
                Context context_ = nContextId._createContext();
                context_._setHandle(this);
                mContexts[contextId_] = context_;
            }
        }

        public void _addRunnable(IRunnable nRunnable) {
            mRunnable.Add(nRunnable);
        }

        public void _runHandle() {
        }

        public Handle(uint nIndex, byte nType) {
            mContexts = new Dictionary<uint, Context>();
            mRunnable = new List<IRunnable>();
            mIndex = nIndex;
            mType = nType;
        }

        Dictionary<uint, Context> mContexts;
        const string TAG = "Handle";
        List<IRunnable> mRunnable;
        uint mIndex;
        byte mType;
    }
}
