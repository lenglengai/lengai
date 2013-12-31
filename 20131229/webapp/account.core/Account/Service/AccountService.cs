using System.Collections.Generic;

using common.core;

namespace account.core
{
    public class AccountService : PropertySink, IHeadstream
    {
        public void _headSerialize(ISerialize nSerialize)
        {
        }

        public string _streamName()
        {
            return @"accountService";
        }

        public void _runInit()
        {
        }

        public AccountService()
        {
            mAccountMgrs = new Dictionary<uint, AccountMgr>();
        }

        Dictionary<uint, AccountMgr> mAccountMgrs;
    }
}
