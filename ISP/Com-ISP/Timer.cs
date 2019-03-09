using System.Threading.Tasks;

namespace Com_ISP
{
    public class Timer : ITimerClient
    {
        private ITimerClient _client;

        public void Register(int timeout, ITimerClient client)
        {
            _client = client;
            Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(timeout);
                TimeOut();
            });
        }

        #region ITimerClient
        public void TimeOut()
        {
            _client.TimeOut();
        }
        #endregion ITimerClient
    }
}
