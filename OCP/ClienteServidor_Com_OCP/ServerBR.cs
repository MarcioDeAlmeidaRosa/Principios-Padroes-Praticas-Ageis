using System;

namespace ClienteServidor_Com_OCP
{
    public class ServerBR : IClient
    {
        public void Ligar()
        {
            Console.WriteLine("Ligando servidor no BR");
        }

        public void Desligar()
        {
            Console.WriteLine("Desligando servidor no BR");
        }
    }
}
