using System;

namespace Exercicio_III___Media
{
    class Program
    {
        static void Main(string[] args)
        {
            MediasNotas notas = new MediasNotas();

            Console.WriteLine("Nome do Aluno :");
            Console.WriteLine("Digite as tres notas do aluno: ");
            notas.N1 = double.Parse(Console.ReadLine());
            notas.N2 = double.Parse(Console.ReadLine());
            notas.N3 = double.Parse(Console.ReadLine());

            double res = notas.NotaFinal();
            

          


        }
    }
}
