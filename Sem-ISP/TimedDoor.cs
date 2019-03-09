using System;

namespace Sem_ISP
{
    public class TimedDoor : Door
    {
        public TimedDoor()
        {
            Console.WriteLine("Criando instância de porta com temporizador");
        }

        public override bool IsDoorOpen()
        {
            Console.WriteLine("Executando IsDoorOpen() da classe TimedDoor");
            return base.IsDoorOpen();
        }

        public override void Lock()
        {
            Console.WriteLine("Executando Lock() da classe TimedDoor");
            base.Lock();
        }

        public override void TimeOut()
        {
            Console.WriteLine("Executando TimeOut() da classe TimedDoor");
            base.TimeOut();
        }

        public override void Unlock()
        {
            Console.WriteLine("Executando Unlock() da classe TimedDoor");
            base.Unlock();
        }
    }
}
