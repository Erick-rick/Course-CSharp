using System;

namespace Exercicio_VI___Reserva_de_quarto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos você´irá reservar?");
            int n = int.Parse(Console.ReadLine());

            ReservaQuarto[] vect = new ReservaQuarto[n];

            for(int quarto = 0; quarto < 9; quarto++) {
                for(int q = 0; q < n; q++) { 
                
                } Console.WriteLine("Nome: ");
                string name = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto: ");
                int numberQuarto = int.Parse(Console.ReadLine());

                vect[numberQuarto] = new ReservaQuarto {Nome = name, Email = email, Quarto = numberQuarto };
                
            }

// Console
        }
    }
}
