using System;
using System.Threading;

namespace ClienteServidor_Sem_OCP
{
    public class Client
    {
        /// <summary>
        /// Forma de implementação viola o princípio OCP, pois se existir a necessidade
        /// de implementar novos requisitos no projeto, teremos que mudar código que já
        /// funciona, e com isso podemos causar alterações em outros módulos, que não precisariam
        /// ser afetados com o requisito solicitado.
        /// </summary>
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
