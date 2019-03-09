namespace Com_ISP
{
    public interface ITimedDoor : IDoor
    {
        void DoorTimeout(int timeoutId);
    }
}
