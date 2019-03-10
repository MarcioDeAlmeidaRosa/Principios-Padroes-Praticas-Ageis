using System;
using System.Threading;

namespace ClienteServidor_Com_OCP
{
    public class Client
    {
        private readonly IClient _client;

        public Client(IClient client)
        {
            _client = client;
        }

        public void TarefasDiaria()
        {
            _client.Ligar();

            Trabalhar();

            _client.Desligar();
        }

        private void Trabalhar()
        {
            Console.WriteLine("Trabalhando durante o dia todo");
            Thread.Sleep(10000);
        }
    }
}
