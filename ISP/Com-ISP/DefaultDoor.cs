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
            Console.WriteLine("Executando IsDoorOpen() da classe DefaultDoor e encaminhando para o respectivo método da classe base");
            Console.WriteLine("------------------------");
            return base.IsDoorOpen();
        }

        public override void Lock()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando Lock() da classe DefaultDoor e encaminhando para o respectivo método da classe base");
            Console.WriteLine("------------------------");
            base.Lock();
        }

        public override void TimeOut()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando TimeOut() da classe DefaultDoor e encaminhando para o respectivo método da classe base");
            Console.WriteLine("------------------------");
            base.TimeOut();
        }

        public override void Unlock()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Executando Unlock() da classe DefaultDoor e encaminhando para o respectivo método da classe base");
            Console.WriteLine("------------------------");
            base.Unlock();
        }
    }
}
