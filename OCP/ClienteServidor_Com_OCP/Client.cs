using System;
using System.Threading;

namespace ClienteServidor_Com_OCP
{
    public class Client
    {
        /// <summary>
        /// Com a alteração para criar uma interface cliente para os clientes
        /// desta forma não temos mais um código fixo, onde ele só conhece
        /// um servidor específico, com esta alteração, deixamos a classe de 
        /// cliente fechada para modificação, porém aberta para ampliação,
        /// caso seja necessário criar novas implementações no server,
        /// não precisamos mexer nas classes já implementadas e funcionando no projeto atual,
        /// criamos um novo fornecedor para a classe cliente, e nele implementando os novos requisitos.
        /// </summary>
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
