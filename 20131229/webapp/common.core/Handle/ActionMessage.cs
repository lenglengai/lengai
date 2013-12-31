namespace common.core
{
    public class ActionMessage : IStream
    {
        public void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mId, @"id");
        }
        
        public ulong _getId()
        {
            return mId;
        }

        public ActionMessage(ulong nId)
        {
            mId = nId;
        }

        ulong mId;
    }
}
