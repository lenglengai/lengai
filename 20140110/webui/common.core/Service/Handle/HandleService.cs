using System.Collections.Generic;
using System.Threading;

namespace common.core
{
    public class HandleService
    {
        public void _runStart() {
            WaitCallback waitCallback = new WaitCallback(_runHandle);
            foreach (KeyValuePair<uint, Handle> i in mHandles) {
                ThreadPool.QueueUserWorkItem(waitCallback, i.Value);
            }
        }

        static void _runHandle(object nHandle) {
            Handle handle_ = (Handle)nHandle;
            //handle_._runHandle();
        }

        public void _runPreinit() {
            InitService initService =
                __singleton<InitService>._instance();
            initService.m_tRunInit += this._runInit;
            initService.m_tRunStart += this._runStart;
        }

        public void _runInit() {
            this._initHandle();
        }

        public void _initHandle() {
            HandleConfig handleConfig = new HandleConfig();
            this._initConfig(handleConfig);
            handleConfig._initHandle(this);
        }

        void _initConfig(HandleConfig nHandleConfig) {
            string streamName_ = nHandleConfig._streamName();
            string handleConfigUrl_ = @"Config/handle.xml";
            XmlReader xmlReader_ = new XmlReader();
            xmlReader_._openUrl(handleConfigUrl_);
            xmlReader_._selectStream(streamName_);
            nHandleConfig._headSerialize(xmlReader_);
            xmlReader_._runClose();
        }

        public void _addHandleCount(uint nIndex, uint nCount) {
            mHandleCount[nIndex] = nCount;
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

        public void _addHandle(uint nIndex, Handle nHandle) {
            mHandles[nIndex] = nHandle;
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
