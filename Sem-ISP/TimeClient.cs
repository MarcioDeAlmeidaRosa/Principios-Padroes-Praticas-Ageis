using System;

namespace Sem_ISP
{
    class TimeClient : ITimerClient
    {
        private Timer _timer;

        public TimeClient()
        {
            _timer = new Timer();
            _timer.Register(10000, this);
        }

        #region ITimerClient
        public void TimeOut()
        {
            Console.WriteLine("Executando método TimeOut() da classe TimeClient");
        }
        #endregion ITimerClient
    }
}
