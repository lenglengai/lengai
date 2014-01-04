using System.Threading;
using System.Collections.Generic;

namespace common.core
{
    public class Handle
    {
        public void _addActionHeader(ActionHeader nActionHeader) {
            lock (mSyncObject) {
                mActionHeaders.Enqueue(nActionHeader);
            }
        }

        public void _initContext(IContextId nContextId) {
            uint contextId_ = nContextId._getContextId();
            if (mContexts.ContainsKey(contextId_)) {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_initContext:{0}", contextId_);
                logService_._logError(TAG, logError);
            } else {
                Context context_ = 
                    nContextId._createContext();
                context_._setHandle(this);
                mContexts[contextId_] = context_;
            }
        }

        public void _addRunnable(IRunnable nRunnable) {
            mRunnable.Add(nRunnable);
        }

        void _runRunnables() {
            foreach (IRunnable i in mRunnable) {
                i._startRun();
            }
        }

        void _runActionHeader() {
            ActionHeader actionHeader = null;
            lock (mSyncObject) {
                actionHeader = mActionHeaders.Dequeue();
            }
            uint contextId = actionHeader._getContextId();
            if (mContexts.ContainsKey(contextId)) {
                Context context = mContexts[contextId];
                ActionBody actionBody = 
                    actionHeader._getActionBody();
                context._runActionBody(actionBody);
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_runActionHeader:{0}", contextId);
                logService_._logError(TAG, logError);
            }
        }

        public void _runHandle() {
            while (this._runInternal()) ;
        }

        bool _runInternal() {
            if (mType == HandleType_.mStop) return true;
            if ((mType == HandleType_.mRunnable)
                || (mType == HandleType_.mAll))
            {
                this._runRunnables();
            }
            if ((mType == HandleType_.mAction)
                || (mType == HandleType_.mAll))
            {
                this._runActionHeader();
            }
            Thread.Sleep(1);
            return false;
        }

        public Handle(uint nIndex, byte nType) {
            mContexts = new Dictionary<uint, Context>();
            mActionHeaders = new Queue<ActionHeader>();
            mRunnable = new List<IRunnable>();
            mIndex = nIndex;
            mType = nType;
        }

        readonly object mSyncObject = new object();
        Dictionary<uint, Context> mContexts;
        Queue<ActionHeader> mActionHeaders;
        const string TAG = "Handle";
        List<IRunnable> mRunnable;
        uint mIndex;
        byte mType;
    }
}
