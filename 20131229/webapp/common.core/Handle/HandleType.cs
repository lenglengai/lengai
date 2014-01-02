using System.Collections.Generic;

namespace common.core
{
    public class HandleType : IStream
    {
        public void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mId, "id");
            nSerialize._serialize(ref mType, "type");
            nSerialize._serialize(ref mCount, "count");
            nSerialize._serialize(ref mPropertySink, "propertySink");
        }

        public PropertySink _getPropertySink()
        {
            return mPropertySink;
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
            mPropertySink = null;
            mCount = 0;
            mType = 0;
            mId = 0;
        }
        
        PropertySink mPropertySink;
        byte mCount;
        byte mType;
        uint mId;
    }
}
