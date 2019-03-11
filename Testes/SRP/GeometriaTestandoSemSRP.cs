using Geometria_Sem_SRP;
using System;

namespace ISPTeste.SRP
{
    public class GeometriaTestandoSemSRP : ITestavel
    {
        public void Testar()
        {
            UsandoRetangle();
        }

        private void UsandoRetangle()
        {
            Retangle retangle = new Retangle(10, 20);
            Console.WriteLine(retangle.Area());
            retangle.Draw();
        }
    }
}
