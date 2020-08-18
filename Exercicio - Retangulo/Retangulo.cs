using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio___Retangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return (2 * Largura) + (2 * Altura);
        }

        public double Diagonal() {
            Double d = (Math.Pow(Largura, 2) + Math.Pow(Altura,2));
            Double raiz = Math.Sqrt(d);

            return raiz;

        }
    }
}
