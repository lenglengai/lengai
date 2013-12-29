namespace action.core
{
    public interface IActionHandle
    {
        void _runActionMessage(
            ActionMessage nActionMessage);

        ulong _getId();
    }
}
