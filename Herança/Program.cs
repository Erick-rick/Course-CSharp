using Herança.Entities;
using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Conta1 = new Account(001, "Ana", 0.0);
            BusinessAccount Bconta = new BusinessAccount(8010, "Charlie Teste", 100.0, 500.0);

            Console.WriteLine(Bconta.Balance);
            //Protected 
            // conta.Balance = 200.0;

            // UPCASTING
            Account conta3 = Bconta;
            Account conta4 = new BusinessAccount(002, "Bob", 0.0, 300.0);
            Account conta5 = new SavingAccount(003, "Maria", 1000.0, 0.3);

            //DOWNCASTING
            BusinessAccount conta6 = (BusinessAccount)conta4;
            conta6.Loan(100.0);

            //BusinessAcount conta7 = (BusinessAccount)conta5 ; -> Erro de Execução

            if( conta5 is BusinessAccount) {
                //BusinessAccount conta7 = (BusinessAccount)conta5;
                BusinessAccount conta7 = conta5 as BusinessAccount;
                conta7.Loan(300);
                Console.WriteLine("Loan!");
            }

            if(conta5 is SavingAccount) {
                SavingAccount conta7 = (SavingAccount)conta5;
                conta7.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}
