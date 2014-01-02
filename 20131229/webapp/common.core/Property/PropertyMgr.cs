using System.Collections.Generic;

namespace common.core
{
    public class PropertyMgr
    {
        public __t _getProperty<__t>(uint nPropertyId)
            where __t : IProperty
        {
            __t result_ = default(__t);
            if (mPropertys.ContainsKey(nPropertyId)) {
                result_ = (__t)mPropertys[nPropertyId];
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_getProperty:{0}", nPropertyId);
                logService_._logError(TAG, logError);
            }
            return result_;
        }

        public void _addPropertyId(IPropertyId nPropertyId) {
            uint propertyId_ = nPropertyId._getPropertyId();
            if (mPropertys.ContainsKey(propertyId_)) {
                LogService logService_ = 
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_addPropertyId:{0}", propertyId_);
                logService_._logError(TAG, logError);
            } else {
                IProperty property_ =
                    nPropertyId._createProperty();
                property_._setPropertyMgr(this);
                property_._runPreinit();
                mPropertys[propertyId_] = property_;
            }
        }

        public void _runInit() {
            foreach (KeyValuePair<uint, IProperty> i
                in mPropertys) {
                IProperty property_ = i.Value;
                property_._runInit();
            }
        }

        public PropertyMgr() {
            mPropertys = new
                Dictionary<uint, IProperty>();
        }

        Dictionary<uint, IProperty> mPropertys;
        const string TAG = "PropertyMgr";
    }
}
