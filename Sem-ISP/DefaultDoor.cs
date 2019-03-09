using System;

namespace Sem_ISP
{
    public class DefaultDoor : Door
    {
        public DefaultDoor()
        {
            Console.WriteLine("Criando instância de porta pardão");
        }

        public override bool IsDoorOpen()
        {
            Console.WriteLine("Executando IsDoorOpen() da classe DefaultDoor");
            return base.IsDoorOpen();
        }

        public override void Lock()
        {
            Console.WriteLine("Executando Lock() da classe DefaultDoor");
            base.Lock();
        }

        public override void TimeOut()
        {
            Console.WriteLine("Executando TimeOut() da classe DefaultDoor");
            base.TimeOut();
        }

        public override void Unlock()
        {
            Console.WriteLine("Executando Unlock() da classe DefaultDoor");
            base.Unlock();
        }
    }
}
