namespace common.core
{
    public class VersionNews : CommonNews
    {
        public override uint _getNewsId()
        {
            return CONSTS.VERSION;
        }

        public VersionNews()
        {
        }
    }
}
