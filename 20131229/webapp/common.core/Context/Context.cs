namespace common.core
{
    public class Context
    {
        public void _runActionBody(ActionBody nActionBody) {
        }

        public void _addRunnable(IRunnable nRunnable) {
            mHandle._addRunnable(nRunnable);
        }
        
        public void _setHandle(Handle nHandle) {
            mHandle = nHandle;
        }

        public Context() {
            mHandle = null;
        }

        Handle mHandle;
    }
}
