using System;

namespace Exercicio_II____Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Nome: ");
            f.Nome = Console.ReadLine();

            Console.WriteLine("Salário Bruto: ");
            f.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionario : {f.Nome}, R$ {f.Salario}");

            Console.WriteLine("Digite a porcetagem para aumentar o sálario: ");
            double porc = double.Parse(Console.ReadLine());
            f.AumentarSalario(porc);

            Console.WriteLine($"Dados atualizados {f.Nome}, {f.Salario} ");


        }
    }
}
