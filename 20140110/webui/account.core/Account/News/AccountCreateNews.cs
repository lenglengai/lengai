using common.core;

namespace account.core
{
    public class AccountCreateNews : AccountNews
    {
        public override void _serialize(ISerialize nSerialize)
        {
            base._serialize(nSerialize);
            nSerialize._serialize(ref mError, "error");
        }

        public override int _getNewsId()
        {
            return CONSTS.CREATE;
        }

        public void _setError(int nError)
        {
            mError = nError;
        }

        public int _getError()
        {
            return mError;
        }

        public AccountCreateNews()
        {
            mError = 0;
        }

        int mError;
    }
}
