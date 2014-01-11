using common.core;

namespace account.core
{
    public abstract class AccountNews : News
    {
        public override string _getContext()
        {
            return CONSTS.CONTEXT;
        }
    }
}
