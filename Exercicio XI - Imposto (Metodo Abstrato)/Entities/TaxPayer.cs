using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_XI___Imposto__Metodo_Abstrato_.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public TaxPayer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Tax();
    }
}
