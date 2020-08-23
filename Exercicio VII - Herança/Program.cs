using Exercicio_VII___Herança.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_VIII___Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lista = new List<Employee>();

            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Employee # {i} data: ");
                Console.WriteLine("Outsourced (Y/N)");
                string outsourced = Console.ReadLine();
                outsourced.ToUpper();
                // if(outsourced = Y) { 
                Console.WriteLine("Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Hours :");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per Hour");
                double valueHr = double.Parse(Console.ReadLine());

                if(outsourced == "Y") {
                    Console.WriteLine("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine());
                    lista.Add(new OutsourcedEmployee(name, hours, valueHr, additional));
                } else {
                    lista.Add(new Employee(name, hours, valueHr));
                }

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Payments");
                foreach(Employee emp in lista) {
                    Console.WriteLine(emp.Name + "- R$ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
