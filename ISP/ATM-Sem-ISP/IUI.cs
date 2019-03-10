namespace ATM_Sem_ISP
{
    public interface IUI
    {
        decimal RequestDepositAmt();
        decimal RequestWithdramalAmt();
        decimal RequestTransferAmt();
        void InformInsufficientFunds();
    }
}
