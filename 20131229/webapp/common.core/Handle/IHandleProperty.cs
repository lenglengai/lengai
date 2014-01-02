using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace common.core
{
    public interface IHandleProperty
    {
        void _runPreinit();

        void _runInit();

        void _setPropertyMgr
            (PropertyMgr nPropertyMgr);

        __t _getPropertyMgr<__t>()
            where __t : PropertyMgr;
    }
}
