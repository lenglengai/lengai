namespace common.core
{
    public interface IActionRun
    {
        void _runActionMessage(
            ActionMessage nActionMessage);

        ulong _getId();
    }
}
