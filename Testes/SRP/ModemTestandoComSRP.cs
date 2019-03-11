using Modem_Com_SRP;
using System;

namespace ISPTeste.SRP
{
    public class ModemTestandoComSRP : ITestavel
    {
        public void Testar()
        {
            UsandoModem();
        }

        private void UsandoModem()
        {
            Modem modem = new Modem();
            SolicitaDiscagem(modem, "123456789");
            EnviaMensagem(modem, 'i');
            RecebendoMensagem(modem);
            EncerraDiscagem(modem);
        }

        private void SolicitaDiscagem(IConnection dataChannel, string number)
        {
            dataChannel.Dial(number);
        }

        private void EncerraDiscagem(IConnection dataChannel)
        {
            dataChannel.Hangup();
        }

        private void EnviaMensagem(IDataChannel dataChannel, char _char)
        {
            dataChannel.Send(_char);
        }

        private void RecebendoMensagem(IDataChannel dataChannel)
        {
            Console.WriteLine(dataChannel.Recv());
        }

    }
}
