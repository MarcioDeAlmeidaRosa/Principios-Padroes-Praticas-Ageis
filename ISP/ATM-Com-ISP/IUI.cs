namespace ATM_Com_ISP
{
    public interface IUI : IWithdrawaUI, ITransferUI, IDepositUI
    {
        void InformInsufficientFunds();
    }
}
