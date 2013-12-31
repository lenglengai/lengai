using System.Threading;
using System.Collections.Generic;

namespace common.core
{
    public class HandleService : IHeadstream
    {
        public void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mHandleTypes, "handleTypes");
        }

        public string _streamName()
        {
            return @"handleService";
        }

        public void _register(Handle nHandle)
        {
            ThreadPool.QueueUserWorkItem(
                new WaitCallback(_runHandle), nHandle);
        }

        public void _register(byte nType, IPropertyId nPropertyId) {
            if (mPropertySinks.ContainsKey(nType)) {
                PropertySink propertSink = mPropertySinks[nType];
                propertSink._registerCreate(nPropertyId);
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"HandleService _register IPropertyId:{0}", nType);
                logService_._logError(logError);
            }
        }

        static void _runHandle(object nHandle)
        {
            Handle handle_ = (Handle)nHandle;
            handle_._runHandle();
        }

        public void _runPreinit() {
            this._initConfig();
        }

        void _initConfig() {
            string accountConfigUrl_ =
                @"Config/handleConfig.xml";
            XmlReader xmlReader_ = new XmlReader();
            xmlReader_._openUrl(accountConfigUrl_);
            xmlReader_._selectStream(_streamName());
            this._headSerialize(xmlReader_);
            xmlReader_._runClose();
        }

        public void _runInit() {
            this._initPropertySink();
            this._initHandle();
            this._startHandle();
        }

        void _initPropertySink() {
            foreach (HandleType i in mHandleTypes) {
                byte count = i._getCount();
                byte type = i._getType();
                this._initPropertySink(type);
            }
        }

        void _initPropertySink(byte nType){
            if (!mPropertySinks.ContainsKey(nType)) {
                PropertySink propertSink = new PropertySink();
                mPropertySinks[nType] = propertSink;
            }  else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"HandleService _initPropertySink{0}", nType);
                logService_._logError(logError);
            }
        }

        void _initHandle() {
            byte index = 1;
            foreach (HandleType i in mHandleTypes) {
                byte count = i._getCount();
                byte type = i._getType();
                for (byte j = 0; j < count; ++j) {
                    Handle handle =
                        new Handle(index, type);
                    this._initHandle(type, handle);
                    mHandles[index] = handle;
                    ++index;
                }
            }
        }

        void _initHandle(byte nType, Handle nHandle) {
            if (mPropertySinks.ContainsKey(nType)) {
                PropertySink propertSink = mPropertySinks[nType];
                propertSink._runCreate(nHandle);
            } else {
                LogService logService_ = 
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"HandleService _initHandle:{0}", nType);
                logService_._logError(logError);
            }
        }

        public void _startHandle() {
            foreach (KeyValuePair<uint, Handle>
                i in mHandles) {
                this._register(i.Value);
            }
        }

        public HandleService() {
            mHandles = new Dictionary<uint, Handle>();
            mPropertySinks = new Dictionary<byte, PropertySink>();
        }

        Dictionary<byte, PropertySink> mPropertySinks;
        Dictionary<uint, Handle> mHandles;
        List<HandleType> mHandleTypes;
    }
}
