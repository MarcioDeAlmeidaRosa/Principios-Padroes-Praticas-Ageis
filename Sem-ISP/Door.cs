using System;

namespace Sem_ISP
{
    abstract class Door : IDoor, ITimerClient
    {
        #region IDoor
        private bool _isDoorOpen { get; set; }

        public Door()
        {
            _isDoorOpen = true;
        }

        public virtual bool IsDoorOpen()
        {
            Console.WriteLine("Executando IsDoorOpen() da classe base Door");
            return _isDoorOpen;
        }

        public virtual void Lock()
        {
            Console.WriteLine("Executando Lock() da classe base Door");

            if (!IsDoorOpen())
            {
                Console.WriteLine("Erro - Porta já esta fechada");
                return;
            }
            _isDoorOpen = false;
            Console.WriteLine("Fechando a porta");
        }

        public virtual void Unlock()
        {
            Console.WriteLine("Executando TimeOut() da classe base Door");
            if (IsDoorOpen())
            {
                Console.WriteLine("Erro - Porta já esta aberta");
                return;
            }
            _isDoorOpen = true;
            Console.WriteLine("Abrindo a porta");
        }
        #endregion IDoor

        #region ITimerClient
        public virtual void TimeOut()
        {
            Console.WriteLine("Executando Unlock() da classe base Door");

            Console.WriteLine("Tempo limite atingigo com a porta aberta");
            Lock();
        }
        #endregion ITimerClient
    }
}
