using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_XI___Imposto__Metodo_Abstrato_.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double income, double healthExpenditures): base(name, income)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(Income <= 20000.00) {
                return Income * 0.15 - HealthExpenditures * 0.5;
            } else {
                return (Income * 0.25) - (HealthExpenditures * 0.5);
            }
            
        }
    }
}
