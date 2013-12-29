using common.core;

namespace action.core
{
    public abstract class HandleSink : PropertySink, IHandleMgr
    {
        public event _HandleSlot m_tRegisterHandle;
        public void _registerHandle(Handle nHandle)
        {
            if (null != m_tRegisterHandle)
            {
                this.m_tRegisterHandle(nHandle);
            }
        }

        public abstract ulong _getId();

        public void _runInit() {
            HandleService handleService_ =
                __singleton<HandleService>._instance();
            handleService_._register(this);
        }

        public HandleSink() {
            m_tRegisterHandle = null;
        }
    }
}
