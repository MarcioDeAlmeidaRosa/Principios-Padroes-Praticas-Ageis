using ClienteServidor_Com_OCP;
using System;

namespace ISPTeste
{
    public class ClientServidorTestandoComOCP : ITestavel
    {
        public void Testar()
        {
            ExecutarTrabalhoBR();

            ExecutarTrabalhoUSA();
        }

        private void ExecutarTrabalhoBR()
        {
            try
            {
                Client client = new Client(new ServerBR());
                client.TarefasDiaria();
                Console.WriteLine("Finalizado o dia de trabalho no Brasil.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ExecutarTrabalhoUSA()
        {
            try
            {
                Client client = new Client(new ServerUSA());
                client.TarefasDiaria();
                Console.WriteLine("Finalizado o dia de trabalho nos Estados Unidos da America.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
