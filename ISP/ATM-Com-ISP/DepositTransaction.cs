namespace ATM_Com_ISP
{
    public class DepositTransaction : ITransaction
    {
        private readonly IDepositUI _ui;

        public DepositTransaction(IDepositUI ui)
        {
            _ui = ui;
        }

        public void Execute()
        {
            _ui.RequestDepositAmt();
        }
    }
}
