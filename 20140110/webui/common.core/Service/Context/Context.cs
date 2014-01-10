namespace common.core
{
    public class Context
    {
        public void _setHandle(Handle nHandle) {
            mHandle = nHandle;
        }

        public Context() {
            mHandle = null;
        }

        const string TAG = "Context";
        Handle mHandle;
    }
}
