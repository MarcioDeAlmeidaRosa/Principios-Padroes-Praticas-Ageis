namespace Geometria_Sem_SRP
{
    public interface IDataChannel
    {
        void Send(char c); //Enviar
        char Recv(); //Receber
    }
}
