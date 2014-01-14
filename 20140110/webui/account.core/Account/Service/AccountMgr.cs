using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using common.core;

namespace account.core
{
    public class AccountMgr
    {
        public NewsMgr _createAccount(AccountCreateS mAccountCreateS) {
            SqlCommand sqlCommand_ = new SqlCommand();
            AccountCreateB accountCreateB_ = new AccountCreateB(mAccountCreateS, mId);
            sqlCommand_._addHeadstream(accountCreateB_);
            SqlService sqlService_ = __singleton<SqlService>._instance();
            sqlService_._runSqlCommand(sqlCommand_);
            return null;
        }

        public AccountMgr(uint nId)
        {
            mId = nId;
        }

        uint mId;
    }
}
