namespace common.core
{
    public class PropertyMgrId<__t> : IPropertyMgrId
        where __t : IPropertyMgr, new()
    {
        public IPropertyMgr _createPropertyMgr() {
            return new __t();
        }

        public static uint _getNameId() {
            string className_ = typeof(__t).FullName;
            return GenerateId._runCommon(className_);
        }

        public uint _getPropertyMgrId() {
            if (0 == TAG) {
                TAG = _getNameId();
            }
            return TAG;
        }

        public PropertyMgrId() {
        }

        static uint TAG = 0;
    }
}
