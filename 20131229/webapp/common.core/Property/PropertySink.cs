using System.Collections.Generic;

namespace common.core
{
    public class PropertySink : IHeadstream
    {
        public void _runCreate(PropertyMgr nPropertyMgr) {
            foreach (KeyValuePair<uint, IPropertyId> i in mCreates) {
                IPropertyId propertyId_ = i.Value;
                nPropertyMgr._addPropertyId(propertyId_);
            }
            nPropertyMgr._runInit();
        }

        public PropertySink() {
            mCreates = new Dictionary<uint, IPropertyId>();
        }

        Dictionary<uint, IPropertyId> mCreates;
    }
}
