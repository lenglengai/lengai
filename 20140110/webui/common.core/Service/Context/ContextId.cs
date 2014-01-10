namespace common.core
{
    public class ContextId<__t> : IContextId
        where __t : Context, new()
    {
        public Context _createContext() {
            return new __t();
        }

        public static uint _classId() {
            if (0 == TAG) {
                string className_ = typeof(__t).FullName;
                TAG = GenerateId._runCommon(className_);
            }
            return TAG;
        }

        public uint _getContextId() {
            if (0 == TAG) {
                TAG = _classId();
            }
            return TAG;
        }

        public ContextId() {
        }

        static uint TAG = 0;
    }
}
