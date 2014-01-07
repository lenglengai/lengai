using System.Collections.Generic;

using common.core;

namespace account.core
{
    public class AccountService
    {
        public uint _createAccount(uint nPlatform, string nAccountName,
            string nNickname, string nPassward, string nGetPassward)
        {
            uint hashName_ = GenerateId._runTableId(nAccountName);
            uint accountMgrIndex_ = hashName_ % mHandleCount;
            AccountMgr accountMgr_ = mAccountMgrs[accountMgrIndex_];
            return accountMgr_._createAccount(nPlatform, nAccountName,
                nNickname, nPassward, nGetPassward);
        }

        public AccountLoginC _loginAccount(string nAccountName,
            string nPassward, uint nDeviceType)
        {
            uint hashName_ = GenerateId._runTableId(nAccountName);
            uint accountMgrIndex_ = hashName_ % mHandleCount;
            AccountMgr accountMgr_ = mAccountMgrs[accountMgrIndex_];
            return accountMgr_._loginAccount(nAccountName,
                nPassward, nDeviceType);
        }

        public void _runPreinit() {
            ActionService actionService_ =
                __singleton<ActionService>._instance();
            actionService_._addServerHandle
                (ActionType_.mAccount_, _getAccountHandle);
            HandleService handleService = 
                __singleton<HandleService>._instance();
            mHandleCount = handleService._getHandleCount
                (ActionType_.mAccount_);
        }

        public void _runInit() {
        }

        void _initAccountMgr() {
            for (uint i = 0; i < mHandleCount; ++i) {
                AccountMgr accountMgr_ = new AccountMgr(i);
                mAccountMgrs[i] = accountMgr_;
            }
        }

        __tuple<uint, uint> _getAccountHandle(uint nCount) {
            SettingService settingService_ = __singleton<SettingService>._instance();
            uint serverCount = settingService_._getServerCount();
            serverCount = (nCount / serverCount) + 1;
            uint handleCount = (nCount / mHandleCount) + 1;
            return new __tuple<uint, uint>(serverCount, handleCount);
        }

        public AccountService() {
            mAccountMgrs = new Dictionary<uint, AccountMgr>();
            mHandleCount = 0;
        }

        Dictionary<uint, AccountMgr> mAccountMgrs;
        uint mHandleCount;
    }
}
