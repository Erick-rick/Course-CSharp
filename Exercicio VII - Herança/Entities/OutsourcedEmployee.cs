using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_VII___Herança.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalChange { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalChange): base(name, hours, valuePerHour)
        {
            AdditionalChange = additionalChange;
        }


        public OutsourcedEmployee()
        {
            
        }

        public override double Payment()
        {
            return base.Payment()+ 1.1 * AdditionalChange;
        }


    }
}
