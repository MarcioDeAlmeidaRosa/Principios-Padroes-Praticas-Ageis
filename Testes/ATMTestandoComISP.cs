using ATM_Com_ISP;
using System;

namespace ISPTeste
{
    public class ATMTestandoComISP : ITestavel
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
                ITransaction transacao = new TransferTransaction(new ATMUI(300));
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
                ITransaction transacao = new WithdrawaTransaction(new ATMUI(300));
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
                ITransaction transacao = new DepositTransaction(new ATMUI(300));
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
