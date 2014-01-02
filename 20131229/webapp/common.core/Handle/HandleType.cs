using System.Collections.Generic;

namespace common.core
{
    public class HandleType : IStream
    {
        public void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize
                (ref mPropertyMgrSink, "propertyMgrSink");
            nSerialize._serialize(ref mCount, "count");
            nSerialize._serialize(ref mType, "type");
            nSerialize._serialize(ref mId, "id");
        }

        public PropertyMgrSink _getPropertyMgrSink()
        {
            return mPropertyMgrSink;
        }

        public byte _getCount() {
            return mCount;
        }

        public byte _getType() {
            return mType;
        }

        public uint _getId() {
            return mId;
        }

        public HandleType() {
            mPropertyMgrSink = null;
            mCount = 0;
            mType = 0;
            mId = 0;
        }
        
        PropertyMgrSink
            mPropertyMgrSink;
        byte mCount;
        byte mType;
        uint mId;
    }
}
