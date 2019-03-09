namespace Sem_ISP
{
    internal interface IDoor : ITimerClient
    {
        void Lock();
        void Unlock();
        bool IsDoorOpen();
    }
}
