using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_II____Salario
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido() {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcetagem) {

            double aumento = (Salario / porcetagem);
            Salario = (Salario + aumento) - Imposto;
        
        }
    }
}
