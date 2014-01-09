using System.Collections.Generic;

using common.core;

namespace account.core
{
    public class AccountMgr
    {
        public uint _createAccount(uint nPlatform, string nAccountName,
            string nNickname, string nPassward, string nGetPassward)
        {
            uint result_ = AccountError_.mSucess_;
            SqlCommand sqlCommand_ = new SqlCommand();
            AccountCreateB accountCreateB_ = new AccountCreateB(nPlatform,
                nAccountName, nNickname, nPassward, nGetPassward, mId);
            sqlCommand_._addHeadstream(accountCreateB_);
            SqlService sqlService_ = __singleton<SqlService>._instance();
            if (!sqlService_._runSqlCommand(sqlCommand_)) {
                result_ = AccountError_.mSql_;
            }
            return result_;
        }

        public AccountLoginC _loginAccount(string nAccountName, string nPassward, uint nDeviceType)
        {
            SettingService settingService_ = __singleton<SettingService>._instance();
            AccountLoginC result_ = new AccountLoginC();
            result_.m_tServerId = (int)settingService_._getServerId();
            result_.m_tErrorCode = (int)this._checkDevice(nDeviceType);
            if (AccountError_.mSucess_ == result_.m_tErrorCode) {
                this._loginAccountLoginB(nAccountName, nPassward, nDeviceType, result_);
            }
            return result_;
        }

        void _loginAccountLoginB(string nAccountName,
            string nPassward, uint nDeviceType, AccountLoginC nAccountLoginC)
        {
            SqlCommand sqlCommand_ = new SqlCommand();
            AccountLoginB accountLoginB_ = new AccountLoginB(nAccountName, mId);
            sqlCommand_._addHeadstream(accountLoginB_);
            SqlService sqlService_ = __singleton<SqlService>._instance();
            if (!sqlService_._runSqlCommand(sqlCommand_, accountLoginB_)) {
                nAccountLoginC.m_tErrorCode = (int)AccountError_.mSql_;
            }
            if (AccountError_.mSucess_ == nAccountLoginC.m_tErrorCode) {
                nAccountLoginC.m_tErrorCode = (int)accountLoginB_._checkPassward(nPassward);
            }
            if (AccountError_.mSucess_ == nAccountLoginC.m_tErrorCode) {
                this._loginAccount(accountLoginB_, nDeviceType, nAccountLoginC);
            }
        }

        void _loginAccount(AccountLoginB nAccountLoginB, uint nDeviceType, AccountLoginC nAccountLoginC) {
//             Account account_ = this._loginAccount(nAccountLoginB, nDeviceType);
//             nAccountLoginC.m_tAccountId = (int)nAccountLoginB._getAccountId();
//             nAccountLoginC.m_tNickName = nAccountLoginB._getNick();
//             nAccountLoginC.m_tTicks = nAccountLoginB._getTicks();
//             DeviceStatus deviceStatus_ = account_._getDeviceStatus(nDeviceType);
//             nAccountLoginC.m_tDeviceId = deviceStatus_._getId();
//             nAccountLoginC.m_tDeviceType = (int)deviceStatus_._getType();
        }

        Account _loginAccount(AccountLoginB nAccountLoginB, uint nDeviceType) {
            Account result_ = null;
//             uint accountId = nAccountLoginB._getAccountId();
//             if (mAccounts.ContainsKey(accountId))
//             {
//                 result_ = mAccounts[accountId];
//             }
//             if (null == result_)
//             {
//                 result_ = nAccountLoginB._createAccount();
//                 result_._addDeviceType(nDeviceType);
//                 result_._setAccountMgr(this);
//                 AccountCreator accountCreator_ = __singleton<AccountCreator>._instance();
//                 accountCreator_._runCreate(result_);
//                 result_.m_tRunLogin();
//                 mAccounts[accountId] = result_;
//             }
            return result_;
        }

        uint _checkDevice(uint nDeviceType) {
            uint result_ = AccountError_.mSucess_;
            DeviceService deviceService_ = 
                __singleton<DeviceService>._instance();
            if (!deviceService_._contain(nDeviceType)) {
                result_ = AccountError_.mDevice_;
            }
            return result_;
        }

        public AccountMgr(uint nId) {
            mAccounts = new Dictionary<uint, Account>();
            mId = nId;
        }

        Dictionary<uint, Account> mAccounts;
        uint mId;
    }
}
