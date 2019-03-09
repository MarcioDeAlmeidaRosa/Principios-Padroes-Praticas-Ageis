using System;

namespace Com_ISP
{
    public abstract class Door : IDoor
    {
        protected bool _isDoorOpen { get; set; }

        public Door()
        {
            _isDoorOpen = false;
        }

        #region IDoor
        public abstract bool IsDoorOpen();

        public abstract void Lock();

        public abstract void Unlock();
        #endregion IDoor

        #region ITimerClient
        public abstract void TimeOut();
        #endregion ITimerClient
    }
}
