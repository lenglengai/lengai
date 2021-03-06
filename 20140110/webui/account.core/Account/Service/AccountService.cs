﻿using System.Collections.Generic;

using common.core;

namespace account.core
{
    public class AccountService : IHeadstream
    {
        public void _headSerialize(ISerialize nSerialize) {
            nSerialize._serialize(ref mAccountMgrCount, @"accountMgrCount");
        }

        public string _streamName() {
            return @"accountService";
        }

        public NewsMgr _createAccount(AccountCreateS nAccountCreateS) {
            uint hashName_ = GenerateId._runTableId(nAccountCreateS.m_tName);
            uint accountMgrIndex_ = hashName_ % mHandleCount;
            AccountMgr accountMgr_ = mAccountMgrs[accountMgrIndex_];
            return accountMgr_._createAccount(nAccountCreateS);
        }

        public void _runPreinit() {
            InitService initService_ = __singleton<InitService>._instance();
            initService_.m_tRunInit += _runInit;
            this._initConfig();
        }

        void _initConfig() {
            string accountConfigUrl_ = @"Config/accountConfig.xml";
            XmlReader xmlReader_ = new XmlReader();
            xmlReader_._openUrl(accountConfigUrl_);
            xmlReader_._selectStream(_streamName());
            this._headSerialize(xmlReader_);
            xmlReader_._runClose();
        }

        public void _runInit() {
            this._initHandleCount();
            this._initAccountMgr();
        }

        void _initHandleCount() {
            HandleService handleService = __singleton<HandleService>._instance();
            mHandleCount = handleService._getHandleCount("account");
        }

        void _initAccountMgr() {
            for (uint i = 0; i < mAccountMgrCount; ++i) {
                AccountMgr accountMgr_ = new AccountMgr(i);
                mAccountMgrs[i] = accountMgr_;
            }
        }

        __tuple<uint, uint> _getAccountHandle(uint nCount)
        {
            SettingService settingService_ = __singleton<SettingService>._instance();
            uint serverCount = settingService_._getServerCount();
            serverCount = (nCount / serverCount) + 1;
            uint handleCount = (nCount / mHandleCount) + 1;
            return new __tuple<uint, uint>(serverCount, handleCount);
        }

        public AccountService()
        {
            mAccountMgrs = new Dictionary<uint, AccountMgr>();
            mAccountMgrCount = 0;
            mHandleCount = 0;
        }

        Dictionary<uint, AccountMgr> mAccountMgrs;
        const string TAG = "AccountService";
        uint mAccountMgrCount;
        uint mHandleCount;
    }
}
