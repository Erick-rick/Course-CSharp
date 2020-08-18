using System;
using System.Numerics;

namespace Laço_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Ana", "Bob", "Maria" };

            for(int i = 0; i < vetor.Length; i++) {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine("----------------------------------");

            foreach(string nomes in vetor) {
                Console.WriteLine(nomes);
            }
        }
    }
}
