using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace action.core
{
    public interface IHandleMgr
    {
        event _HandleSlot m_tRegisterHandle;
        
        void _registerHandle(Handle nHandle);

        ulong _getId();
    }
}
