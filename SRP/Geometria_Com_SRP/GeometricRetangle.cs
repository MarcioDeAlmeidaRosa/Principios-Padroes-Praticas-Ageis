using System;

namespace Geometria_Com_SRP
{
    public class GeometricRetangle
    {
        /// <summary>
        /// Agora se o cliente de Retangle fizer Retangle mudar, essa alteração não afetará
        /// o cliente de GeometricRetangle
        /// </summary>
        protected readonly double _base;
        protected readonly double _altura;

        public GeometricRetangle(double _base, double altura)
        {
            this._base = _base;
            _altura = altura;
        }

        public double Area()
        {
            Console.WriteLine("Fornecer um modelo matemático da geometria de um retângulo");
            return _base * _altura;
        }
    }
}
