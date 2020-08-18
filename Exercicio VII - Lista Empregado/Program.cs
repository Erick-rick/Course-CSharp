using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_VII___Lista_Empregado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee>list = new List<Employee>();

            Console.WriteLine("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine("Employee #" + i + ":");
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();

            }

            Console.Write("Entry the employyer ud the will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if(emp != null) {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            } else {
                Console.WriteLine("This id does not exist!");
            
            } 
     

            Console.WriteLine("");
            Console.WriteLine("Update list of employyes:");
            foreach(Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
