using System;
using System.Globalization;

namespace Date_Time___Data_e_hora
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = new DateTime(2020, 08, 11);
            DateTime d2 = new DateTime(2020, 08, 11, 20, 45, 3);
            DateTime d3 = new DateTime(2020, 08, 11, 20, 45, 3, 500);
            
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;

            DateTime d6 = DateTime.Parse("2000-08-15");

            DateTime d7 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d8 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);

        }
    }
}
