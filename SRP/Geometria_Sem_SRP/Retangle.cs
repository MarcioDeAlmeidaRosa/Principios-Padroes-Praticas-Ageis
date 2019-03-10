using System;

namespace Geometria_Sem_SRP
{
    public class Retangle
    {
        /// <summary>
        /// Classe retangle tem duas responsabilidades
        /// 1º Fornecer um modelo matemático da geometria de um retângulo
        /// 2º Representar o retêngulo em uma interface gráfica
        /// </summary>
        protected double Base { get; set; }
        protected double Altura { get; set; }

        public void Draw()
        {
            Console.WriteLine("Representar o retêngulo em uma interface gráfica (GUI)");
        }

        public double Area()
        {
            Console.WriteLine("Fornecer um modelo matemático da geometria de um retângulo");
            return Base * Altura;
        }
    }
}
