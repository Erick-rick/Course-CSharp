using System;

namespace Problema_Exemplo___Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            // cria matriz
            for(int i = 0; i < n; n++) {
                string[] valor = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(valor[j]);
                }
            }

            // linha diagonal
            Console.WriteLine("Main diagonal:");
            for(int i = 0; i< n; i++){
                Console.WriteLine();
            }

            //numeros negativos na matriz
            int count = 0;
            for(int i = 0; i < n; i ++) {
                for(int j = 0; j < n; j++) {
                    if(matriz[i, j] < 0) {
                        count++;
                    }
                } 
            }
            Console.WriteLine("Negative number: ");
        }
    }
}
