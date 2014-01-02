﻿namespace common.core
{
    public interface IProperty
    {
        void _runPreinit();

        void _runInit();

        void _setPropertyMgr
            (PropertyMgr nPropertyMgr);

        __t _getPropertyMgr<__t>()
            where __t : PropertyMgr;
    }
}
