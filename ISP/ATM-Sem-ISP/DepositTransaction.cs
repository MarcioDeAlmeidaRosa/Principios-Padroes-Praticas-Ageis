namespace ATM_Sem_ISP
{
    public class DepositTransaction : ITransaction
    {
        private readonly IUI _ui;

        public DepositTransaction(IUI ui)
        {
            _ui = ui;
        }

        public void Execute()
        {
            _ui.RequestDepositAmt();
        }
    }
}
