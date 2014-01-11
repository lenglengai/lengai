namespace account.core
{
    public class AccountCreateNews : AccountNews
    {
        public override uint _getNewsId()
        {
            return CONSTS.CREATE;
        }
    }
}
