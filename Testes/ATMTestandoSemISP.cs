using ATM_Sem_ISP;
using System;

namespace ISPTeste
{
    public class ATMTestandoSemISP : ITestavel
    {
        public void Testar()
        {
            TransferenciaATM();
            SacarATM();
            DepositarATM();
        }

        private void TransferenciaATM()
        {
            try
            {
                IUI ui = new ATMUI(300);
                ITransaction transacao = new TransferTransaction(ui);
                transacao.Execute();
                Console.WriteLine("Valor transferido com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void SacarATM()
        {
            try
            {
                IUI ui = new ATMUI(300);
                ITransaction transacao = new WithdrawaTransaction(ui);
                transacao.Execute();
                Console.WriteLine("Valor sacado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void DepositarATM()
        {
            try
            {
                IUI ui = new ATMUI(300);
                ITransaction transacao = new DepositTransaction(ui);
                transacao.Execute();
                Console.WriteLine("Valor depositado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
