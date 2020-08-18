using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_IV___Conversor_de_Moeda
{
    class ConversorDeMoeda
    {
        public static double Cotacao;
     
        public double ComprarDolar(double qtdComprar) {
            return Cotacao * qtdComprar;
        }

        public static double ValorCompra(double ComprarDolar) {
            return ((6 / 100)* ComprarDolar) + ComprarDolar;
        }
    }
}
