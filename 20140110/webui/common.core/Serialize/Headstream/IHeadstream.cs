namespace common.core
{
    public interface IHeadstream
    {
        void _headSerialize(ISerialize nSerialize);

        string _streamName();
    }
}
