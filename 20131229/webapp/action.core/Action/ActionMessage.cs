using common.core;

namespace action.core
{
    public class ActionMessage : IStream
    {
        public void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mCount, @"count");
            nSerialize._serialize(ref mType, @"type");
            nSerialize._serialize(ref mId, @"id");
        }
        
        public uint _getCount()
        {
            return mCount;
        }

        public uint _getType()
        {
            return mType;
        }

        public uint _getId()
        {
            return mId;
        }

        public ActionMessage(uint nId,
            uint nType, uint nCount)
        {
            mCount = nCount;
            mType = nType;
            mId = nId;
        }

        uint mCount;
        uint mType;
        uint mId;
    }
}
