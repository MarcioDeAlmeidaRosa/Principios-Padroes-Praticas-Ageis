using System;

namespace Com_ISP
{
    public class DoorTimerAdapter : ITimerClient
    {
        private Timer _timer;
        private readonly TimedDoor _timedDoor;

        public DoorTimerAdapter(TimedDoor timedDoor)
        {
            _timedDoor = timedDoor;

            Console.WriteLine("Registrando time");
            _timer = new Timer();
            _timer.Register(
                int.Parse(System.Configuration.ConfigurationManager.AppSettings["configuration-timeout-door-open"]),
                timedDoor.GetHashCode(),
                this);
        }

        public void Timeout(int timeoutId)
        {
            _timedDoor.DoorTimeout(timeoutId);
        }
    }
}
