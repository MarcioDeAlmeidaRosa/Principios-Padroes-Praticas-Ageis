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
                new TestandoSemISP(),
                new TestandoSemISP()
            };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando testes");

            _testaveis[0].Testar();
        }
    }
}
