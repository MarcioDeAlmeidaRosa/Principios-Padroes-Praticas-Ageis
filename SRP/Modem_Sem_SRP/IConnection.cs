namespace Modem_Com_SRP
{
    public interface IConnection
    {
        void Dial(string pno); //Discar
        void Hangup(); //Desligar
    }
}
