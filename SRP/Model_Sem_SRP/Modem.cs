using System;

namespace Model_Sem_SRP
{
    /// <summary>
    /// Exemplo de violação da SRP
    /// pois qualquer alteração na forma de discar e desligar for feita, 
    /// terá que ser testado e distribuído o componente para a troca e recebimento
    /// de mensagens
    /// </summary>
    public class Modem : IModem
    {
        public void Dial(string pno)
        {
            Console.WriteLine($"Efetuando discagem para ${pno}");
        }

        public void Hangup()
        {
            Console.WriteLine($"Desligando.");
        }

        public char Recv()
        {
            Console.WriteLine($"Recebendo");
            return 'c';
        }

        public void Send(char c)
        {
            Console.WriteLine($"Enviando mensagem {c}");
        }
    }
}
