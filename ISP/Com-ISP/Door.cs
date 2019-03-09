using System;

namespace Com_ISP
{
    public abstract class Door : IDoor
    {
        private Timer _timer;

        #region IDoor
        private bool _isDoorOpen { get; set; }

        public Door()
        {
            _isDoorOpen = false;
        }

        public bool IsDoorOpen()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando IsDoorOpen() da classe base Door");
            Console.WriteLine("------------------------");
            return _isDoorOpen;
        }

        public void Lock()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando Lock() da classe base Door");

            if (!IsDoorOpen())
            {
                Console.WriteLine("Erro - Porta já esta fechada");
                return;
            }
            Console.WriteLine("Fechando a porta");
            _isDoorOpen = false;
            Console.WriteLine("Porta fechada com sucesso");
            Console.WriteLine("------------------------");
        }

        public void Unlock()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando TimeOut() da classe base Door");
            if (IsDoorOpen())
            {
                Console.WriteLine("Erro - Porta já esta aberta");
                return;
            }
            Console.WriteLine("Abrindo a porta");
            _isDoorOpen = true;
            Console.WriteLine("Registrando time");
            _timer = new Timer();
            _timer.Register(int.Parse(System.Configuration.ConfigurationManager.AppSettings["configuration-timeout-door-open"]), this);
            Console.WriteLine("Porta aberta com sucesso");
            Console.WriteLine("------------------------");
        }
        #endregion IDoor

        #region ITimerClient
        public void TimeOut()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Tempo limite atingigo com a porta aberta - solicitando fechamento de porta automático");
            Lock();
            Console.WriteLine("------------------------");
        }
        #endregion ITimerClient
    }
}
