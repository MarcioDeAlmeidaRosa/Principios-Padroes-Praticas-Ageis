using ISPTeste.SRP;
using System;

namespace ISPTeste
{
    class Program
    {
        private static ITestavel[] _testaveis;

        static Program()
        {
            _testaveis = new ITestavel[]
            {
                new DoorTestandoSemISP(),//0
                new DoorTestandoComISP(),//1
                new ATMTestandoSemISP(),//2
                new ATMTestandoComISP(),//3
                new ClientServidorTestandoSemOCP(),//4
                new ClientServidorTestandoComOCP(),//5
                new ModemTestandoSemSRP(),//6
                new ModemTestandoComSRP(),//7
                new GeometriaTestandoSemSRP(),//8
                new GeometriaTestandoComSRP(),//9
            };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando testes");
            Console.WriteLine("------------------------");

            _testaveis[9].Testar();

            Console.WriteLine("------------------------");
            Console.WriteLine("Pressione OK para encerrar...");
            Console.ReadKey();
        }
    }
}
