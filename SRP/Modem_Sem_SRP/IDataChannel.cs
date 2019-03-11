namespace Modem_Com_SRP
{
    public interface IDataChannel
    {
        void Send(char c); //Enviar
        char Recv(); //Receber
    }
}
