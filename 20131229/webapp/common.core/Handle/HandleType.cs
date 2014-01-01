namespace common.core
{
    public class HandleType : IStream
    {
        public void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mId, "id");
            nSerialize._serialize(ref mType, "type");
            nSerialize._serialize(ref mCount, "count");
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
            mCount = 0;
            mType = 0;
            mId = 0;
        }

        byte mCount;
        byte mType;
        uint mId;
    }
}
