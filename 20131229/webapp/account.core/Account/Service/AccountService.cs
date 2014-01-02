using System.Collections.Generic;

using common.core;

namespace account.core
{
    public class AccountService
    {
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
