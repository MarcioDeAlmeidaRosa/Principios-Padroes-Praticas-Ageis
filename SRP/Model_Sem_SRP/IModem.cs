namespace Model_Sem_SRP
{
    public interface IModem
    {
        void Dial(string pno); //Discar
        void Hangup(); //Desligar
        void Send(char c); //Enviar
        char Recv(); //Receber
    }
}
