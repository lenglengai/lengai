using System.Collections.Generic;

namespace common.core
{
    public class PropertySink : IStream
    {
        public void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mPropertyId, "propertyId");
        }

        public void _runCreate(PropertyMgr nPropertyMgr)
        {
            foreach (KeyValuePair<uint, IPropertyId> i in mPropertyIds)
            {
                IPropertyId propertyId_ = i.Value;
                nPropertyMgr._addPropertyId(propertyId_);
            }
            nPropertyMgr._runInit();
        }

        public void _runInit() {
            foreach (string i in mPropertyId) {
                this._initPropertyId(i);
            }
        }

        void _initPropertyId(string nName) {
            PropertyService propertyService_ =
                __singleton<PropertyService>._instance();
            uint id = GenerateId._runCommon(nName);
            IPropertyId propertyId =
                propertyService_._getPropertyId(id);
            if (!mPropertyIds.ContainsKey(id)) {
                mPropertyIds[id] = propertyId;
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_getPropertyId:{0}", nName);
                logService_._logError(TAG, logError);
            }
        }

        public PropertySink()
        {
            mPropertyIds = new Dictionary<uint, IPropertyId>();
            mPropertyId = new List<string>();
        }

        Dictionary<uint, IPropertyId> mPropertyIds;
        const string TAG = "PropertySink";
        List<string> mPropertyId;
    }
}
