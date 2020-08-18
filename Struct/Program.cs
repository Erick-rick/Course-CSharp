using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            //a variavel devera ser iniciada
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);
            p = new Point();

            Console.WriteLine(p);

            //Nullable - Valores nulo

            //double z  = null; **Opção invalida
            double? a = null;
            double? b = 10.0;

            //Imprimir o valor da variavel ou valor padrão
            Console.WriteLine(a.GetValueOrDefault());
            Console.WriteLine(b.GetValueOrDefault());

            //Imprimir se a variavel tem valor
            Console.WriteLine(a.HasValue);
            Console.WriteLine(b.HasValue);

            //imprimir diretamento o valor

            if(a.HasValue) {
                Console.WriteLine(a.Value);
            } else {
                Console.WriteLine("A is null !");
            }

            if(b.HasValue) {
                Console.WriteLine(a.Value);
            } else {
                Console.WriteLine("B is null !");
            }

            //Operador de coalescencia nula

            double? c = null;
            double? d = 10;

            //Se a variavel for nula irá imprimir 5, se não o valor da variavel
            double e = c ?? 5;
            double f = d ?? 5;

            Console.WriteLine(e);
            Console.WriteLine(f);
        }
    }
}
