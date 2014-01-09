namespace common.core
{
    public class News : IStream
    {
        public void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mId, "id");
        }

        public News()
        {
            mId = 0;
        }

        uint mId;
    }
}
