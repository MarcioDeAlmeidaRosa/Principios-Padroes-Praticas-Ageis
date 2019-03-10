using Sem_ISP;
using System;

namespace ISPTeste
{
    class DoorTestandoSemISP : ITestavel
    {
        public void Testar()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Iniciando testes (TestandoSemISP)");
            Console.WriteLine("------------------------");
            CriarPortaPadrao();
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
    }
}
