using System.Collections.Generic;
using System.Threading;

using common.core;

namespace action.core
{
    public class HandleService
    {
        public void _register(IHandleMgr nHandleMgr) {
            ulong id_ = nHandleMgr._getId();
            if (!mHandleMgrs.ContainsKey(id_)) {
                mHandleMgrs[id_] = nHandleMgr;
                nHandleMgr.m_tRegisterHandle +=
                    this._registerHandle;
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError =
                    string.Format(@"HandleService _register:{0}",
                        id_);
                logService_._logError(logError);
            }
        }

        void _registerHandle(Handle nHandle) {
            ThreadPool.QueueUserWorkItem(
                new WaitCallback(_runHandle), nHandle);
        }

        static void _runHandle(object nHandle)
        {
            Handle handle_ = (Handle)nHandle;
            handle_._runHandle();
        }

        public void _runPreinit() {
            mHandleMgrs =
                new Dictionary<ulong, IHandleMgr>();
        }

        public HandleService() {
        }
        Dictionary<ulong, IHandleMgr> mHandleMgrs;
    }
}
