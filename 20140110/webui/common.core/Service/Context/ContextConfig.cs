using System.Collections.Generic;

namespace common.core
{
    public class ContextConfig : IHeadstream
    {
        public void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mContexts, "contexts");
            nSerialize._serialize(ref mName, "name");
        }

        public string _streamName() {
            return "contextConfig";
        }

        public void _initHandle(Handle nHandle) {
            foreach (string i in mContexts) {
                this._initContextId(i, nHandle);
            }
        }

        void _initContextId(string nName, Handle nHandle) {
            uint id = GenerateId._runCommon(nName);
            ContextService contextService_ = __singleton<ContextService>._instance();
            IContextId contextId = contextService_._getContextId(id);
            nHandle._initContext(contextId);
        }

        public string _getName() {
            return mName;
        }

        public ContextConfig()
        {
            mContexts = new List<string>();
            mName = null;
        }

        List<string> mContexts;
        string mName;
    }
}
