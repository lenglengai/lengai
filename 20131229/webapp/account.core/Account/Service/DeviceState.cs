namespace account.core
{
    public class DeviceState
    {
        public void _setType(uint nType)
        {
            mType = nType;
        }

        public uint _getType()
        {
            return mType;
        }

        public void _setId(uint nId)
        {
            mId = nId;
        }

        public long _getId()
        {
            return mId;
        }

        public DeviceState(long nId, uint nType)
        {
            mId = nId;
            mType = nType;
        }

        public DeviceState()
        {
            mId = 0;
            mType = 0;
        }

        long mId;
        uint mType;
    }
}
