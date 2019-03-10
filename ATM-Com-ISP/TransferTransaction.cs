namespace ATM_Com_ISP
{
    public class TransferTransaction : ITransaction
    {
        private readonly ITransferUI _ui;

        public TransferTransaction(ITransferUI ui)
        {
            _ui = ui;
        }

        public void Execute()
        {
            _ui.RequestTransferAmt();
        }
    }
}
