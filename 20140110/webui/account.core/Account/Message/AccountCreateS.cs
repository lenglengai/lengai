using common.core;

namespace account.core
{
    public class AccountCreateS : Packet
    {
        public string m_tName { get; set; }
        public string m_tNick { get; set; }
        public string m_tPassward { get; set; }
        public string m_tGetPassward { get; set; }
    }
}
