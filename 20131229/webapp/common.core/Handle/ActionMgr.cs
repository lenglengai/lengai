using System.Collections.Generic;

namespace common.core
{
    public class ActionMgr
    {
        public void _pushActionMessage(ActionMessage nActionMessage) {
            mActionMessages.Add(nActionMessage);
        }

        public IList<ActionMessage> _getActionMessages() {
            return mActionMessages;
        }

        public ActionMgr() {
            mActionMessages = new List<ActionMessage>();
        }

        List<ActionMessage> mActionMessages;
    }
}
