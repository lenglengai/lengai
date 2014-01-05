using System.Collections.Generic;

using common.core;

namespace account.core
{
    public class AccountService
    {
        public uint _createAccount(int nPlatform, string nAccountName,
            string nNickname, string nPassward, string nGetPassward)
        {
            uint hashName_ = GenerateId._runTableId(nAccountName);
            uint accountMgrIndex_ = hashName_ % mAccountMgrCount;
            AccountMgr accountMgr_ = mAccountMgrs[accountMgrIndex_];
            return accountMgr_._createAccount(nPlatform, nAccountName,
                nNickname, nPassward, nGetPassward);
        }

        public void _runPreinit() {
        }

        public void _runInit() {
        }

        public AccountService() {
            mAccountMgrs = new Dictionary<uint, AccountMgr>();
        }

        Dictionary<uint, AccountMgr> mAccountMgrs;
    }
}
