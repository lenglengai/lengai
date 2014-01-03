namespace common.core
{
    public class Action : IStream
    {
        public void _serialize(ISerialize nSerialize) {
            nSerialize._serialize(ref mActionHeader, "actionHeader");
            nSerialize._serialize(ref mActionCount, "actionCount");
            nSerialize._serialize(ref mActionType, "actionType");
        }

        public ActionHeader _getAtionHeader() {
            return mActionHeader;
        }

        public void _setActionCount(uint nActionCount) {
            mActionCount = nActionCount;
        }

        public uint _getActionCount() {
            return mActionCount;
        }

        public void _setActionType(uint nActionType) {
            mActionType = nActionType;
        }

        public uint _getActionType() {
            return mActionType;
        }

        public Action() {
            mActionHeader = new ActionHeader();
            mActionCount = 0;
            mActionType = 0;
        }

        ActionHeader mActionHeader;
        uint mActionCount;
        uint mActionType;
    }
}
