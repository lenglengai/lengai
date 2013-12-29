using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using common.core;
using action.core;

namespace account.core
{
    public class AccountService : HandleSink, IHeadstream
    {
        public void _headSerialize(ISerialize nSerialize)
        {
        }

        public string _streamName()
        {
        }

        public override ulong _getId()
        {
        }
    }
}
