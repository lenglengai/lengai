using System;

using common.core;

namespace account.core
{
    public class AccountCreateB : ISqlHeadstream
    {
        public void _runSelect(ISqlCommand nSqlCommand) {
            nSqlCommand._serialize(ref mAccountId, @"accountId");
            nSqlCommand._serialize(ref mAccountName, @"accountName");
            nSqlCommand._serialize(ref mNickName, @"nickName");
            nSqlCommand._serialize(ref mPassward, @"passward");
            nSqlCommand._serialize(ref mGetPassward, @"getPassward");
            nSqlCommand._serialize(ref mTicks, @"createTime");
        }

        public void _runWhere(ISqlCommand nSqlCommand) {
        }

        public string _tableName() {
            return ("account_" + mAccountMgrId);
        }

        public SqlType_ _sqlType() {
            return SqlType_.mInsert_;
        }

        public AccountCreateB(AccountCreateS mAccountCreateS, uint nAccountMgrId) {
            mAccountId = GenerateId._runNameId(mAccountCreateS.m_tName);
            mAccountName = mAccountCreateS.m_tName;
            mAccountMgrId = nAccountMgrId;
            mNickName = mAccountCreateS.m_tNick;
            mPassward = mAccountCreateS.m_tPassward;
            mGetPassward = mAccountCreateS.m_tGetPassward;
            mTicks = DateTime.Now.Ticks;
        }

        uint mAccountId;
        string mAccountName;
        string mNickName;
        string mPassward;
        string mGetPassward;
        long mTicks;
        uint mAccountMgrId;
    }
}
