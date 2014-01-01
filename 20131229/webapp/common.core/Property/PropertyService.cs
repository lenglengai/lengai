using System.Collections.Generic;

namespace common.core
{
    public class PropertyService
    {
        public void _registerPropertyId(IPropertyId nPropertyId) {
            uint propertyId_ = nPropertyId._getId();
            if (mPropertyIds.ContainsKey(propertyId_)) {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_registerPropertyId:{0}", propertyId_);
                logService_._logError(TAG, logError);
            } else {
                mPropertyIds[propertyId_] = nPropertyId;
            }
        }

        public IPropertyId _getPropertyId(uint nPropertyId) {
            IPropertyId result_ = null;
            if (mPropertyIds.ContainsKey(nPropertyId)) {
                result_ = mPropertyIds[nPropertyId];
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_getPropertyId:{0}", nPropertyId);
                logService_._logError(TAG, logError);
            }
            return result_;
        }

        public PropertyService() {
            mPropertyIds = new Dictionary<uint, IPropertyId>();
        }

        Dictionary<uint, IPropertyId> mPropertyIds;
        const string TAG = "PropertyService";
    }
}
