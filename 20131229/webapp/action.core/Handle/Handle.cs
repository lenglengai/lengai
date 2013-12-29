using System.Collections.Generic;

namespace action.core
{
    public abstract class Handle
    {
        public void _pushActionMgr(
            ActionMgr nActionMgr)
        {
            lock (mSyncObject) {
                mActionMgrs.Enqueue(nActionMgr);
            }
        }

        public void _runHandle() {
            ActionMgr actionMgr = null;
            lock (mSyncObject)
            {
                actionMgr =
                    mActionMgrs.Dequeue();
            }
            actionMgr._runActionMessage();
        }

        public Handle() {
            mActionMgrs =
                new Queue<ActionMgr>();
        }

        Queue<ActionMgr> mActionMgrs;
        readonly object mSyncObject =
            new object();
    }
}
