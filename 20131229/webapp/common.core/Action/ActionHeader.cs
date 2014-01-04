namespace common.core
{
    public class ActionHeader : IStream
    {
        public void _serialize(ISerialize nSerialize) {
            nSerialize._serialize(ref mActionBody, "actionBody");
        }

        public ActionBody _getActionBody() {
            return mActionBody;
        }

        public uint _getContextId() {
            return mContextId;
        }

        public ActionHeader() {
            mActionBody = new ActionBody();
        }

        ActionBody mActionBody;
        uint mContextId;
    }
}
