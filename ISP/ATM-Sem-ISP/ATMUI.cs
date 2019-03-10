using System;

namespace ATM_Sem_ISP
{
    public class ATMUI : IUI
    {
        private decimal _saldo = 0;

        public ATMUI(decimal saldo)
        {
            _saldo = saldo;
        }

        public void InformInsufficientFunds()
        {
            if (_saldo <= 0)
            {
                throw new Exception("Não existe saldo suficiente");
            }
        }

        public decimal RequestDepositAmt()
        {
            Console.WriteLine("Informe o valor para depósito:");
            var valor = Console.ReadLine();
            decimal valorConvertido = 0;
            if (!decimal.TryParse(valor, out valorConvertido))
            {
                Console.WriteLine("Valor informado incorreto:");
            }
            _saldo += valorConvertido;
            return valorConvertido;
        }

        public decimal RequestTransferAmt()
        {
            Console.WriteLine("Informe o valor para tranferência:");
            var valor = Console.ReadLine();
            decimal valorConvertido = 0;
            if (!decimal.TryParse(valor, out valorConvertido))
            {
                Console.WriteLine("Valor informado incorreto:");
            }
            _saldo -= valorConvertido;
            InformInsufficientFunds();
            return valorConvertido;
        }

        public decimal RequestWithdramalAmt()
        {
            Console.WriteLine("Informe o valor para saque:");
            var valor = Console.ReadLine();
            decimal valorConvertido = 0;
            if (!decimal.TryParse(valor, out valorConvertido))
            {
                Console.WriteLine("Valor informado incorreto:");
            }
            _saldo -= valorConvertido;
            InformInsufficientFunds();
            return valorConvertido;
        }
    }
}
