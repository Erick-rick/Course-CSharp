using Exercicio_XI___Imposto__Metodo_Abstrato_.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_XI___Imposto__Metodo_Abstrato_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.WriteLine("Enter the Number of tax Payer: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++) {
                Console.WriteLine($"Tax payer #{n} data: ");
                Console.WriteLine("Individual or company (i/c)?");
                string type = Console.ReadLine();

                Console.WriteLine("Name");
                string name = Console.ReadLine();
                Console.WriteLine("Anual income: ");
                double income = double.Parse(Console.ReadLine());

                if(type == "i") {
                    Console.WriteLine("Health Expenditures :");
                    double health = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, income, health));
                } else {
                    Console.WriteLine("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                }

                Console.WriteLine("------------------------------------");
                Console.WriteLine("Taxes Paid :");
                double sum = 0.0;
                foreach(TaxPayer taxPayer in list) {
                    double tax = taxPayer.Tax();
                    Console.WriteLine(taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                    sum += tax;
                }

                Console.WriteLine();
                Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
