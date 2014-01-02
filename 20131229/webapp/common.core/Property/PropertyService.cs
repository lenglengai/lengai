using System.Collections.Generic;

namespace common.core
{
    public class PropertyService
    {
        public void _registerPropertyMgrId(IPropertyMgrId nPropertyMgrId)
        {
            uint propertyMgrId_ = nPropertyMgrId._getPropertyMgrId();
            if (mPropertyMgrIds.ContainsKey(propertyMgrId_)) {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_registerPropertyMgrId:{0}", propertyMgrId_);
                logService_._logError(TAG, logError);
            } else {
                mPropertyMgrIds[propertyMgrId_] = nPropertyMgrId;
            }
        }

        public IPropertyMgrId _getPropertyMgrId(uint nPropertyMgrId) {
            IPropertyMgrId result_ = null;
            if (mPropertyMgrIds.ContainsKey(nPropertyMgrId)) {
                result_ = mPropertyMgrIds[nPropertyMgrId];
            } else {
                LogService logService_ =
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_getPropertyMgrId:{0}", nPropertyMgrId);
                logService_._logError(TAG, logError);
            }
            return result_;
        }

        public void _registerPropertyId(IPropertyId nPropertyId) {
            uint propertyId_ = nPropertyId._getPropertyId();
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
            mPropertyMgrIds = new Dictionary<uint, IPropertyMgrId>();
            mPropertyIds = new Dictionary<uint, IPropertyId>();
        }

        Dictionary<uint, IPropertyMgrId> mPropertyMgrIds;
        Dictionary<uint, IPropertyId> mPropertyIds;
        const string TAG = "PropertyService";
    }
}
