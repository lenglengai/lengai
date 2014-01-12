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
            __tuple<int, string> tuple_ = sqlService_._runSqlCommand(sqlCommand_);
            int errorCode = tuple_._get_0();
            NewsMgr result = new NewsMgr();
            AccountCreateNews accountCreateNews = new AccountCreateNews();
            if (0 == errorCode) {
                accountCreateNews._setError(CONSTS.CREATESUCESS);
            } else if (1062 == errorCode) {
                accountCreateNews._setError(CONSTS.CREATENAME);
            } else {
                accountCreateNews._setError(CONSTS.ERROR);
                LogService logService_ = __singleton<LogService>._instance();
                string logError = string.Format(@"sqlError:{0},{1}", errorCode, tuple_._get_1());
                logService_._logError(logError);
            }
            result._addNews(accountCreateNews);
            return result;
        }

        public AccountMgr(uint nId)
        {
            mId = nId;
        }

        uint mId;
    }
}
