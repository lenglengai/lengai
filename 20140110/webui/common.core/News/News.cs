namespace common.core
{
    public abstract class News : IStream
    {
        public virtual void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mId, "id");
        }

        public abstract string _getContext();

        public abstract int _getNewsId();

        public long _getId()
        {
            return mId;
        }

        public News()
        {
            string context = this._getContext();
            int contextId = (int)GenerateId._runCommon(context);
            int newsId = this._getNewsId();
            mId = (contextId << 32) + newsId;
        }

        long mId;
    }
}
