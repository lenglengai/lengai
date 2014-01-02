using System.Collections.Generic;

namespace common.core
{
    public class PropertyMgrSink : IStream
    {
        public void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mPropertyMgrId, "propertyMgrId");
        }

        public void _runCreate(PropertyMgrs nPropertyMgrs)
        {
            foreach (KeyValuePair<uint, IPropertyMgrId> i in mPropertyMgrIds)
            {
                IPropertyMgrId propertyMgrId_ = i.Value;
                nPropertyMgrs._addPropertyMgrId(propertyMgrId_);
            }
            nPropertyMgr._runInit();
        }

        public void _runInit()
        {
            foreach (string i in mPropertyMgrId)
            {
                this._initPropertyMgrId(i);
            }
        }

        void _initPropertyMgrId(string nName)
        {
            PropertyService propertyService_ =
                __singleton<PropertyService>._instance();
            uint id = GenerateId._runCommon(nName);
            IPropertyMgrId propertyMgrId =
                propertyService_._getPropertyMgrId(id);
            if (!mPropertyMgrIds.ContainsKey(id)) {
                mPropertyMgrIds[id] = propertyMgrId;
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_initPropertyMgrId:{0}", nName);
                logService_._logError(TAG, logError);
            }
        }

        public IDictionary<uint, IPropertyMgrId> _getPropertyMgrIds() {
            return mPropertyMgrIds;
        }

        public PropertyMgrSink() {
            mPropertyMgrIds = new Dictionary<uint, IPropertyMgrId>();
            mPropertyMgrId = new List<string>();
        }

        Dictionary<uint, IPropertyMgrId> mPropertyMgrIds;
        const string TAG = "PropertyMgrSink";
        List<string> mPropertyMgrId;
    }
}
