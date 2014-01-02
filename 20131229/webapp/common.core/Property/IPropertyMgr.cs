namespace common.core
{
    public interface IPropertyMgr
    {
        public __t _getProperty<__t>(uint nPropertyId)
            where __t : IProperty;

        void _addPropertyId(IPropertyId nPropertyId);

        void _runInit();
    }
}
