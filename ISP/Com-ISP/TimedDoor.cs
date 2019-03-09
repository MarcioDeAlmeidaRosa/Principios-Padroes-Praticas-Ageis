using System;

namespace Com_ISP
{
    public class TimedDoor : ITimedDoor
    {
        private bool _isDoorOpen;

        public TimedDoor()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Criando instância de porta com temporizador");
            Console.WriteLine("------------------------");
            _isDoorOpen = false;
        }

        #region ITimedDoor
        public void DoorTimeout(int timeoutId)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Tempo limite atingigo com a porta aberta - solicitando fechamento de porta automático");
            Lock();
            Console.WriteLine("------------------------");
        }

        #region IDoor
        public bool IsDoorOpen()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando IsDoorOpen() da classe base TimedDoor");
            Console.WriteLine("------------------------");
            return _isDoorOpen;
        }

        public void Lock()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando Lock() da classe base TimedDoor");

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
            Console.WriteLine("Executando TimeOut() da classe base TimedDoor");
            if (IsDoorOpen())
            {
                Console.WriteLine("Erro - Porta já esta aberta");
                return;
            }
            Console.WriteLine("Abrindo a porta");
            _isDoorOpen = true;

            //TODO: verificar se será preciso armazenar a variável
            new DoorTimerAdapter(this);

            Console.WriteLine("Porta aberta com sucesso");
            Console.WriteLine("------------------------");
        }
        #endregion

        #endregion ITimedDoor
    }
}
