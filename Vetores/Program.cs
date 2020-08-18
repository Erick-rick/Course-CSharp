using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for(int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //soma 
            double sum = 0.0;
            for(int i = 0; i < n; i++) {
                sum += vect[i];
            }

            //media
            double avg = sum / n;
            Console.WriteLine("AVERAGE HEIGTH = " + avg.ToString("F2", CultureInfo.InvariantCulture));


            Console.WriteLine("Hello World!");
        }
    }
}
