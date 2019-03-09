using System.Threading.Tasks;

namespace Com_ISP
{
    public class Timer : ITimerClient
    {
        private ITimerClient _client;

        public void Register(int timeout, int timeoutId, ITimerClient client)
        {
            _client = client;
            Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(timeout);
                Timeout(timeoutId);
            });
        }

        #region ITimerClient
        public void Timeout(int timeoutId)
        {
            _client.Timeout(timeoutId);
        }
        #endregion ITimerClient
    }
}
