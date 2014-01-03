namespace common.core
{
    public class Action : IStream
    {
        public void _serialize(ISerialize nSerialize) {
            nSerialize._serialize(ref mContext, "context");
        }

        public Action() {
            mContext = 0;
        }

        uint mContext;
    }
}
