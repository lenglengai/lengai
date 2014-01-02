using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace common.core
{
    public class PropertyMgrs
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

        public void _addPropertyMgrId(IPropertyMgrId nPropertyMgrId) {
            uint propertyMgrId_ = nPropertyMgrId._getPropertyMgrId();
            if (mPropertyMgrs.ContainsKey(propertyMgrId_)) {
                LogService logService_ = 
                    __singleton<LogService>._instance();
                string logError = string.Format
                    (@"_addPropertyMgrId:{0}", propertyMgrId_);
                logService_._logError(TAG, logError);
            } else {
                IPropertyMgr propertyMgr_ =
                    nPropertyMgrId._createPropertyMgr();
                propertyMgr_._setPropertyMgr(this);
                propertyMgr_._runPreinit();
                mPropertyMgrs[propertyMgrId_] = propertyMgr_;
            }
        }

        public void _runInit() {
            foreach (KeyValuePair<uint, IPropertyMgr> i
                in mPropertyMgrs)
            {
                IPropertyMgr propertyMgr_ = i.Value;
                propertyMgr_._runInit();
            }
        }

        public PropertyMgrs() {
            mPropertyMgrs = new
                Dictionary<uint, IPropertyMgr>();
        }

        Dictionary<uint, IPropertyMgr> mPropertyMgrs;
        const string TAG = "PropertyMgrs";
    }
}
