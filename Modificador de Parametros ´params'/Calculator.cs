using System;
using System.Collections.Generic;
using System.Text;

namespace Modificador_de_Parametros__params_
{
    class Calculator
    {
       /* public static int Sum2(int n1, int n2) {
            return n1 + n2;
        }
        public static int Sum3(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }*/

        //Params, para não necessitar de instanciar no main
        public static int Sum( params int[] numbers) {
            int soma = 0;
            for(int i =0; i < numbers.Length; i ++) {
                soma = +numbers[i];
            }
            return soma;
        } 
    }
}
