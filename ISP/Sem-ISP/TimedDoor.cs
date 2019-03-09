using System;

namespace Sem_ISP
{
    public class TimedDoor : Door
    {
        public TimedDoor()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Criando instância de porta com temporizador");
            Console.WriteLine("------------------------");
        }

        public override bool IsDoorOpen()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando IsDoorOpen() da classe TimedDoor e encaminhando para o respectivo método da classe base");
            Console.WriteLine("------------------------");
            return base.IsDoorOpen();
        }

        public override void Lock()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando Lock() da classe TimedDoor e encaminhando para o respectivo método da classe base");
            Console.WriteLine("------------------------");
            base.Lock();
        }

        public override void TimeOut()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando TimeOut() da classe TimedDoor e encaminhando para o respectivo método da classe base");
            Console.WriteLine("------------------------");
            base.TimeOut();
        }

        public override void Unlock()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando Unlock() da classe TimedDoor e encaminhando para o respectivo método da classe base");
            Console.WriteLine("------------------------");
            base.Unlock();
        }
    }
}
