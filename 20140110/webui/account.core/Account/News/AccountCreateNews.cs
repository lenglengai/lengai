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

        public override uint _getNewsId()
        {
            return CONSTS.CREATE;
        }

        public void _setError(uint nError)
        {
            mError = nError;
        }

        public uint _getError()
        {
            return mError;
        }

        public AccountCreateNews()
        {
            mError = 0;
        }

        uint mError;
    }
}
