using System.Collections.Generic;

namespace action.core
{
    public class ActionMgr
    {
        public void _pushActionMessage(
            ActionMessage nActionMessage) {
            mActionMessages.Add(nActionMessage);
        }

        public void _runActionMessage() {
            foreach (ActionMessage i
                in mActionMessages) {
            }
        }

        public ActionMgr() {
            mActionMessages
                = new List<ActionMessage>();
        }

        List<ActionMessage> mActionMessages;
    }
}
