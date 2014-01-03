namespace common.core
{
    public class Context
    {
        public void _setHandle(Handle nHandle) {
            mHandle = nHandle;
        }

        public void _addRunnable(IRunnable nRunnable) {
            mHandle._addRunnable(nRunnable);
        }

        public Context() {
            mHandle = null;
        }

        Handle mHandle;
    }
}
