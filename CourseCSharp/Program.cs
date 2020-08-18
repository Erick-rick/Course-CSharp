using System;
using System.Globalization;

namespace CourseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234566;

            Console.WriteLine("Produto");
            Console.WriteLine($"{produto1} cujo o preço é {preco1}");
            Console.WriteLine($"{produto2} cujo o preço é {preco2}\n");

            Console.WriteLine($"{idade} anos de idade, codigo {codigo} e genero:  {genero}\n");

            Console.WriteLine($"Medida com oito casa decimais :{medida}");
            Console.WriteLine($"Arredondado( 3 casas decimais): {medida:F2}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
