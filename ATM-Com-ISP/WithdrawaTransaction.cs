namespace ATM_Com_ISP
{
    public class WithdrawaTransaction : ITransaction
    {
        private readonly IWithdrawaUI _ui;

        public WithdrawaTransaction(IWithdrawaUI ui)
        {
            _ui = ui;
        }

        public void Execute()
        {
            _ui.RequestWithdrawalAmt();
        }
    }
}
