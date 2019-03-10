namespace ATM_Sem_ISP
{
    public class TransferTransaction : ITransaction
    {
        private readonly IUI _ui;

        public TransferTransaction(IUI ui)
        {
            _ui = ui;
        }

        public void Execute()
        {
            _ui.RequestTransferAmt();
        }
    }
}
