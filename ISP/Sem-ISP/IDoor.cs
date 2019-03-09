namespace Sem_ISP
{
    public interface IDoor : ITimerClient
    {
        void Lock();
        void Unlock();
        bool IsDoorOpen();
    }
}
