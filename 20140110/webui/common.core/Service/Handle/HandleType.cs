namespace common.core
{
    public class HandleType : IStream
    {
        public void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mContext, "context");
            nSerialize._serialize(ref mCount, "count");
            nSerialize._serialize(ref mType, "type");
            nSerialize._serialize(ref mId, "id");
        }

        public string _getContext()
        {
            return mContext;
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
            mContext = null;
            mCount = 0;
            mType = 0;
            mId = 0;
        }

        string mContext;
        byte mCount;
        byte mType;
        uint mId;
    }
}
