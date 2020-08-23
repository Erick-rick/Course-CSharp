using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_XI___Imposto__Metodo_Abstrato_.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double income, int numberOfEmployees): base(name, income)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if(NumberOfEmployees <= 10) {
                return Income * 0.14;
            } else {
                return Income * 0.16;
            }
        }
    }
}
