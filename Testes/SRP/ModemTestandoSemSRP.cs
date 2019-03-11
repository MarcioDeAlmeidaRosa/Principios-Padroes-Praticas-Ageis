using Model_Sem_SRP;
using System;

namespace ISPTeste.SRP
{
    public class ModemTestandoSemSRP : ITestavel
    {
        public void Testar()
        {
            UsandoModem();
        }

        private void UsandoModem()
        {
            Modem modem = new Modem();
            modem.Dial("123456789");
            modem.Send('i');
            Console.WriteLine(modem.Recv());
            modem.Hangup();
        }
    }
}
