using System.Collections.Generic;

namespace common.core
{
    public class ContextOption : IStream
    {
        public void _serialize(ISerialize nSerialize) {
            nSerialize._serialize(ref mContextId, "contextId");
        }

        public void _initHandle(Handle nHandle) {
            foreach (string i in mContextId) {
                this._initContextId(i, nHandle);
            }
        }

        void _initContextId(string nName, Handle nHandle) {
            ContextService contextService_ =
                __singleton<ContextService>._instance();
            uint id = GenerateId._runCommon(nName);
            IContextId contextId = 
                contextService_._getContextId(id);
            nHandle._initContext(contextId);
        }

        public ContextOption() {
            mContextId = new List<string>();
        }

        const string TAG = "ContextOption";
        List<string> mContextId;
    }
}
