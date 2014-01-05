namespace common.core
{
    public class ActionHeader : IStream
    {
        public void _serialize(ISerialize nSerialize) {
            nSerialize._serialize(ref mActionBody, "actionBody");
            nSerialize._serialize(ref mContextId, "contextId");
            nSerialize._serialize(ref mActionId, "actionId");
        }

        public IActionBody _getActionBody() {
            return mActionBody;
        }

        public uint _getActionId() {
            return mActionId;
        }

        public uint _getContextId() {
            return mContextId;
        }

        public ActionHeader() {
            mActionBody = null;
            mContextId = 0;
            mActionId = 0;
        }

        IActionBody mActionBody;
        uint mContextId;
        uint mActionId;
    }
}
