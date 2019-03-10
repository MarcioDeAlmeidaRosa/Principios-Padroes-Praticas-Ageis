using System;

namespace Geometria_Com_SRP
{
    public class GeometricRetangle
    {
        /// <summary>
        /// Agora se o cliente de Retangle fizer Retangle mudar, essa alteração não afetará
        /// o cliente de GeometricRetangle
        /// </summary>
        protected double Base { get; set; }
        protected double Altura { get; set; }

        public double Area()
        {
            Console.WriteLine("Fornecer um modelo matemático da geometria de um retângulo");
            return Base * Altura;
        }
    }
}
