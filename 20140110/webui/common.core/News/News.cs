namespace common.core
{
    public abstract class News : IStream
    {
        public void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mId, "id");
        }

        public abstract string _getContext();

        public abstract uint _getNewsId();

        public ulong _getId()
        {
            return mId;
        }

        public News()
        {
            string context = this._getContext();
            uint contextId = GenerateId._runCommon(context);
            uint newsId = this._getNewsId();
            mId = (contextId << 32) + newsId;
        }

        ulong mId;
    }
}
