using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[2, 3];

            //Elementos total da matriz
            Console.WriteLine(matriz.Length);
            //Qtd de linha da matriz
            Console.WriteLine(matriz.Rank);
            //tamanho da dimensão 0 - linha
            Console.WriteLine(matriz.GetLength(0));
            //tamanho da dimensão 1 - coluna
            Console.WriteLine(matriz.GetLength(1));
        }
    }
}
