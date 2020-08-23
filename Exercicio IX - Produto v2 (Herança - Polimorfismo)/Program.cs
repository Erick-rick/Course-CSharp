using Exercicio_IX___Produto_v2__Herança___Polimorfismo_.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio_IX___Produto_v2__Herança___Polimorfismo_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lista = new List<Product>();

            Console.WriteLine("Enter the number of pruduct: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++) {
                Console.WriteLine($"Product #{i} data: ");

                Console.WriteLine("Common, used or imported (c/u/i)?");
                string typeProduct = Console.ReadLine();
                typeProduct.ToUpper();

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(typeProduct == "I") {
                    Console.WriteLine("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine());
                    lista.Add(new ImportedProduct(name, price, customs));

                } else if(typeProduct == "U") {
                    Console.WriteLine("Manufacture date: (DD/MM/YYYY) ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    lista.Add(new UsedProduct(name, price, date));

                } else {
                    lista.Add(new Product(name, price));
                }

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Price Tags: ");
                foreach(Product prod in lista) {
                    Console.WriteLine(prod.PriceTag());

                }
            }
        }
    }
}
