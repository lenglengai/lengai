using System.Collections.Generic;

namespace common.core
{
    public class Handle : PropertyMgr
    {
        public void _register(IActionRun nActionRun) {
            ulong id_ = nActionRun._getId();
            if (!mActionRuns.ContainsKey(id_)) {
                mActionRuns[id_] = nActionRun;
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_register:{0}", id_);
                logService_._logError(TAG, logError);
            }
        }

        public void _runHandle() {
            ActionMgr actionMgr = null;
            lock (mSyncObject) {
                actionMgr = mActionMgrs.Dequeue();
            }
            IList<ActionMessage> actionMessages =
                actionMgr._getActionMessages();
            foreach (ActionMessage i in actionMessages) {
                this._runActionMessage(i);
            }
            actionMessages.Clear();
        }

        void _runActionMessage(ActionMessage nActionMessage) {
            ulong id = nActionMessage._getId();
            if (mActionRuns.ContainsKey(id)) {
                IActionRun actionRun = mActionRuns[id];
                actionRun._runActionMessage(nActionMessage);
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_runActionMessage:{0}", id);
                logService_._logError(TAG, logError);
            }
        }

        public void _pushActionMgr(ActionMgr nActionMgr) {
            lock (mSyncObject) {
                mActionMgrs.Enqueue(nActionMgr);
            }
        }

        public Handle(uint nIndex, byte nType) {
            mActionRuns = new Dictionary<ulong, IActionRun>();
            mActionMgrs = new Queue<ActionMgr>();
            this._setHandleId(nIndex);
            mType = nType;
        }

        readonly object mSyncObject = new object();
        Dictionary<ulong, IActionRun> mActionRuns;
        Queue<ActionMgr> mActionMgrs;
        const string TAG = "Handle";
        byte mType;
    }
}
