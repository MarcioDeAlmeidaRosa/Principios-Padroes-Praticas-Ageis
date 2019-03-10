namespace ATM_Sem_ISP
{
    public class WithdramaTransaction : ITransaction
    {
        private readonly IUI _ui;

        public WithdramaTransaction(IUI ui)
        {
            _ui = ui;
        }

        public void Execute()
        {
            _ui.RequestWithdramalAmt();
        }
    }
}
