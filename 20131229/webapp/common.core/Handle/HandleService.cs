using System.Collections.Generic;
using System.Threading;

namespace common.core
{
    public class HandleService
    {
        public void _addActionHeader(uint nHandle,
            ActionHeader nActionHeader)
        {
            if (mHandles.ContainsKey(nHandle)){
                Handle handle = mHandles[nHandle];
                handle._addActionHeader(nActionHeader);
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_addActionHeader:{0}", nHandle);
                logService_._logError(TAG, logError);
            }
        }

        public void _initHandle() {
            HandleOption handleOption = new HandleOption();
            this._initConfig(handleOption);
            handleOption._initHandle(this);
        }

        void _initConfig(HandleOption nHandleOption) {
            string streamName_ = nHandleOption._streamName();
            string handleConfigUrl_ = @"Config/handleConfig.xml";
            XmlReader xmlReader_ = new XmlReader();
            xmlReader_._openUrl(handleConfigUrl_);
            xmlReader_._selectStream(streamName_);
            nHandleOption._headSerialize(xmlReader_);
            xmlReader_._runClose();
        }

        public uint _getHandleCount(uint nIndex) {
            uint result = 0;
            if (mHandleCount.ContainsKey(nIndex)) {
                result = mHandleCount[nIndex];
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_getHandleCount:{0}", nIndex);
                logService_._logError(TAG, logError);
            }
            return result;
        }

        public void _addHandleCount(uint nIndex, uint nCount) {
            mHandleCount[nIndex] = nCount;
        }

        public void _addHandle(uint nIndex, Handle nHandle) {
            mHandles[nIndex] = nHandle;
        }

        public void _startHandle() {
            foreach (KeyValuePair<uint, Handle> i in mHandles) {
                ThreadPool.QueueUserWorkItem(new WaitCallback(_runHandle), i.Value);
            }
        }

        static void _runHandle(object nHandle) {
            Handle handle_ = (Handle)nHandle;
            handle_._runHandle();
        }

        public void _runPreinit() {
            ActionService actionService_ =
                __singleton<ActionService>._instance();
            actionService_._runPreinit();
            ContextService contextService_ =
                __singleton<ContextService>._instance();
            contextService_._runPreinit();
        }

        public void _runInit() {
            this._initHandle();
        }

        public HandleService() {
            mHandleCount = new Dictionary<uint, uint>();
            mHandles = new Dictionary<uint, Handle>();
        }

        Dictionary<uint, uint> mHandleCount;
        Dictionary<uint, Handle> mHandles;
        const string TAG = "HandleService";
    }
}
