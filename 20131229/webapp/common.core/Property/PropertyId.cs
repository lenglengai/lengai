namespace common.core
{
    public class PropertyId<__t> : IPropertyId
        where __t : IProperty, new()
    {
        public IProperty _createProperty() {
            return new __t();
        }

        public static uint _getNameId() {
            string tag = 
            return GenerateId._runCommon(className_);
        }

        public uint _getId() {
            if (0 == TAG) {
                TAG = _getNameId();
            }
            return TAG;
        }

        public PropertyId() {
        }

        static uint TAG = 0;
    }
}
