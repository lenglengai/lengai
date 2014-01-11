namespace common.core
{
    public abstract class CommonNews : News
    {
        public override string _getContext()
        {
            return CONSTS.CONTEXT;
        }

        public CommonNews()
        {
        }
    }
}
