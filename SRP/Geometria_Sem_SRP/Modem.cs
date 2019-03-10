using System;

namespace Geometria_Sem_SRP
{
    /// <summary>
    /// Note que mantivemos as duas responsabilidades acopladas na classe ainda.
    /// Isso não é desejável, mas pode ser necessário.
    /// Frequentemente existe motivos, relacinados aos detalhes do hardware ou do sistema operacional,
    /// que nos obrigam a acoplar o que normalmente não acoplaríamos. Contudo, separando suas interfaces,
    /// desacoplamos os conceitos no que diz respeito ao restante do aplicativo.
    /// </summary>
    public class Modem : IConnection, IDataChannel
    {
        #region IConnection
        public void Dial(string pno)
        {
            Console.WriteLine($"Efetuando discagem para ${pno}");
        }

        public void Hangup()
        {
            Console.WriteLine($"Desligando.");
        }
        #endregion IConnection

        #region IDataChannel
        public char Recv()
        {
            Console.WriteLine($"Recebendo");
            return 'c';
        }

        public void Send(char c)
        {
            Console.WriteLine($"Enviando mensagem ${c}");
        }
        #endregion IDataChannel
    }
}
