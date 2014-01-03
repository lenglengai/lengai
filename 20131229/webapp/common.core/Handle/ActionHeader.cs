namespace common.core
{
    public class ActionHeader : IStream
    {
        public void _serialize(ISerialize nSerialize) {
            nSerialize._serialize(ref mActionBody, "actionBody");
        }

        public ActionHeader() {
            mActionBody = new ActionBody();
        }

        ActionBody mActionBody;
        uint mContextId;
    }
}
