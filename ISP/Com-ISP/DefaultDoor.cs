using System;

namespace Com_ISP
{
    public class DefaultDoor : Door
    {
        public DefaultDoor()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Criando instância de porta pardão");
            Console.WriteLine("------------------------");
        }

        public override bool IsDoorOpen()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando IsDoorOpen() da classe base DefaultDoor");
            Console.WriteLine("------------------------");
            return _isDoorOpen;
        }

        public override void Lock()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando Lock() da classe base DefaultDoor");

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

        public override void Unlock()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando TimeOut() da classe base DefaultDoor");
            if (IsDoorOpen())
            {
                Console.WriteLine("Erro - Porta já esta aberta");
                return;
            }
            Console.WriteLine("Abrindo a porta");
            _isDoorOpen = true;
            Console.WriteLine("Porta aberta com sucesso");
        }

        public override void TimeOut()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Tempo limite atingigo com a porta aberta - solicitando fechamento de porta automático");
            Lock();
            Console.WriteLine("------------------------");
        }
    }
}
