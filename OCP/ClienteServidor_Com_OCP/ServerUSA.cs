using System;

namespace ClienteServidor_Com_OCP
{
    public class ServerUSA : IClient
    {
        public void Ligar()
        {
            Console.WriteLine("Ligando servidor nos USA");
        }

        public void Desligar()
        {
            Console.WriteLine("Desligando servidor nos USA");
        }
    }
}
