using System.Collections.Generic;

namespace common.core
{
    public class Context
    {
        public void _runActionBody(uint nActionId, IActionBody nActionBody) {
            if (mRunActionBodys.ContainsKey(nActionId)) {
                _RunActionBody runActionBody_ = mRunActionBodys[nActionId];
                runActionBody_(nActionBody);
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_runActionBody:{0}", nActionId);
                logService_._logError(TAG, logError);
            }
        }

        public void _addRunActionBody(uint nActionId, _RunActionBody nRunActionBody) {
            if (mRunActionBodys.ContainsKey(nActionId)) {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_addRunActionBody:{0}", nActionId);
                logService_._logError(TAG, logError);
            } else {
                mRunActionBodys[nActionId] = nRunActionBody;
            }
        }

        public void _addRunnable(IRunnable nRunnable) {
            mHandle._addRunnable(nRunnable);
        }
        
        public void _setHandle(Handle nHandle) {
            mHandle = nHandle;
        }

        public Context() {
            mRunActionBodys = new Dictionary<uint, _RunActionBody>();
            mHandle = null;
        }

        Dictionary<uint, _RunActionBody> mRunActionBodys;
        const string TAG = "Context";
        Handle mHandle;
    }
}
