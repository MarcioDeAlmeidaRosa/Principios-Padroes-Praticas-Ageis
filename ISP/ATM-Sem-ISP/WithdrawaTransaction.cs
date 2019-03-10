namespace ATM_Sem_ISP
{
    public class WithdrawaTransaction : ITransaction
    {
        private readonly IUI _ui;

        public WithdrawaTransaction(IUI ui)
        {
            _ui = ui;
        }

        public void Execute()
        {
            _ui.RequestWithdramalAmt();
        }
    }
}
