namespace common.core
{
    public class ContextId<__t> : IContextId
        where __t : Context, new()
    {
        public Context _createContext() {
            return new __t();
        }

        public static uint _getNameId() {
            string className_ = typeof(__t).FullName;
            return GenerateId._runCommon(className_);
        }

        public uint _getContextId() {
            if (0 == TAG) {
                TAG = _getNameId();
            }
            return TAG;
        }

        public ContextId()
        {
        }

        static uint TAG = 0;
    }
}
