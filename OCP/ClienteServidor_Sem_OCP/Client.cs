using System;
using System.Threading;

namespace ClienteServidor_Sem_OCP
{
    public class Client
    {
        public void TarefasDiaria()
        {
            Server server = new Server();

            server.Ligar();

            Trabalhar();

            server.Desligar();
        }

        private void Trabalhar()
        {
            Console.WriteLine("Trabalhando durante o dia todo");
            Thread.Sleep(10000);
        }
    }
}
