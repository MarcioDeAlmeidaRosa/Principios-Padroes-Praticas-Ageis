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
                new DoorTestandoSemISP(),
                new DoorTestandoComISP(),
                new ATMTestandoSemISP(),
                new ATMTestandoComISP(),
            };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando testes");
            Console.WriteLine("------------------------");

            _testaveis[3].Testar();

            Console.WriteLine("------------------------");
            Console.WriteLine("Pressione OK para encerrar...");
            Console.ReadKey();
        }
    }
}
