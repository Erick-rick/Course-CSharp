using System;
using System.Collections.Generic;
using System.Text;

namespace Herança.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string  Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() { 
        
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        
        //Virtual pode sobrescriver a funçao na subclasse atraves do override
        public virtual void Withdraw(double amouth) {
            Balance -= amouth + 5.0;
        }

        public void Deposit(double amouth) {
            Balance += amouth;
        }

    }


}
