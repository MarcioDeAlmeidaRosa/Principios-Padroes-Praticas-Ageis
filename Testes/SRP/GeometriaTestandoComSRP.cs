using Geometria_Com_SRP;
using System;

namespace ISPTeste.SRP
{
    public class GeometriaTestandoComSRP : ITestavel
    {
        public void Testar()
        {
            UsandoGeometricRetangle();
            UsandoRetangle();
        }

        private void UsandoGeometricRetangle()
        {
            GeometricRetangle retangle = new GeometricRetangle(10, 20);
            Console.WriteLine(retangle.Area());
        }

        private void UsandoRetangle()
        {
            Retangle retangle = new Retangle();
            retangle.Draw();
        }
    }
}
