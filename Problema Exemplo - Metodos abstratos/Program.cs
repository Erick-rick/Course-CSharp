using Problema_Exemplo___Metodos_abstratos.Entities;
using Problema_Exemplo___Metodos_abstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Problema_Exemplo___Metodos_abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.WriteLine("Enter the number of shaper: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++) {

                Console.WriteLine($"Shape #{i} date: ");
                Console.WriteLine("Rectangle or Circle? (r/c)");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Color(Black/Red/Blue): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(ch == 'r') {
                    Console.WriteLine("Width : ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Height : ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));

                } else {
                    Console.WriteLine("Radius : ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));

                }
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Shape Areas");
                foreach(Shape shape in list) {
                    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
                }

            }


        }
    }
}
