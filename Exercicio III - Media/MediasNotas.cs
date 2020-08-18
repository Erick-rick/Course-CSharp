using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_III___Media
{
    class MediasNotas
    {
        public double N1;
        public double N2;
        public double N3;


        public double NotaFinal(){
            double resultado = N1 + N2 + N3;
            double pendencia = 60.0 - resultado;

            if (resultado <= 60.0)
            {
                Console.WriteLine($"NOTA FINAL =>{resultado} \n REPROVADO!\n FALTARAM {pendencia}PONTOS");
            }
            else
            {
                Console.WriteLine($"NOTA FINAL => {resultado} \n APROVADO!");
            }
            return resultado; 
        }
    }
}
