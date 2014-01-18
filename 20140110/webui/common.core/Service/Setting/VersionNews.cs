namespace common.core
{
    public class VersionNews : CommonNews
    {
        public override int _getNewsId()
        {
            return CONSTS.VERSION;
        }

        public VersionNews()
        {
        }
    }
}
