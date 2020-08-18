using System;

namespace Modificador_de_Parametros__params_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema de usar esta forma é ter que criar sobrecarga para soma com mais de 3 numbers
            //int s1 = Calculator.Sum1(2, 3);
            //int s2 = Calculator.Sum2(2, 3, 4);

            //Console.WriteLine(s1);

            //Instaciando um vetor para soma, mas não e muito usual
            //int s3 = Calculator.Sum(new int[] { 2, 3 });
            //int s4 = Calculator.Sum(new int[] { 2, 3 , 4});

            //Melhor forma e usar o params na função da classe
            int s5 = Calculator.Sum(2, 3);
            int s6= Calculator.Sum(2, 3, 7);

            Console.WriteLine(s5);
            Console.WriteLine(s6);


        }
    }
}
