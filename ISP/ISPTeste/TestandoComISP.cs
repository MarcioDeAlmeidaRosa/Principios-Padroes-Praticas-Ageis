using Com_ISP;
using System;

namespace ISPTeste
{
    class TestandoComISP : ITestavel
    {
        public void Testar()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Iniciando testes (TestandoComISP)");
            Console.WriteLine("------------------------");
            CriarPortaComTemporizador();
        }

        private void CriarPortaPadrao()
        {
            DefaultDoor defaultDoor = new DefaultDoor();

            defaultDoor.IsDoorOpen();

            defaultDoor.Unlock();

            Console.WriteLine("------------------------");
            Console.WriteLine("Pressione OK para fechar a porta...");
            Console.ReadKey();

            defaultDoor.Lock();
        }

        private void CriarPortaComTemporizador()
        {
            TimedDoor timedDoor = new TimedDoor();

            timedDoor.IsDoorOpen();

            timedDoor.Unlock();

            Console.WriteLine("------------------------");
            Console.WriteLine("Pressione OK para fechar a porta...");
            Console.ReadKey();

            timedDoor.Lock();
        }
    }
}
