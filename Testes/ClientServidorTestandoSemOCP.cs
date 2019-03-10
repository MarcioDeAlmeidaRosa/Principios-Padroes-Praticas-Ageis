using ClienteServidor_Sem_OCP;
using System;

namespace ISPTeste
{
    public class ClientServidorTestandoSemOCP : ITestavel
    {
        public void Testar()
        {
            ExecutarTrabalho();
        }

        private void ExecutarTrabalho()
        {
            try
            {
                Client client = new Client();
                client.TarefasDiaria();
                Console.WriteLine("Finalizado o dia de trabalho.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
