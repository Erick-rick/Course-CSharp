using System;
using System.Globalization;

namespace Exercicio_V___Transações_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Conta c = new Conta(conta, titular);

            Console.WriteLine("Haverá deposito inicial (s/n)? ");
            string deposito = Console.ReadLine();
            if(deposito == "s" || deposito  == "S") {
                Console.WriteLine("Entre com o valor de deposito inicial :");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Depositar(valor);
            }           

            Console.WriteLine("Dados da Conta : \n" + c);
            Console.WriteLine("----------------------------------------\n");

            Console.WriteLine("Entre com o valor de deposito: ");
            double valorDeposito = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Depositar(valorDeposito);
            Console.WriteLine("Dados Atualizados : \n" + c);
            Console.WriteLine("----------------------------------------\n");

            Console.WriteLine("Entre com o valor de saque ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Sacar(valorSaque);
            Console.WriteLine("Dados Atualizados : \n" + c);
            Console.WriteLine("----------------------------------------\n");



        }
    }
}
