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
        protected readonly double _base;
        protected readonly double _altura;

        public Retangle(double _base, double altura)
        {
            this._base = _base;
            _altura = altura;
        }

        public void Draw()
        {
            Console.WriteLine("Representar o retêngulo em uma interface gráfica (GUI)");
        }

        public double Area()
        {
            Console.WriteLine("Fornecer um modelo matemático da geometria de um retângulo");
            return _base * _altura;
        }
    }
}
