using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio___Produto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade+= quantidade;
        }

        public void RemoverProdutos( int quantidade)
        {
            Quantidade -= quantidade;
        }


        //Irá devolver as 
        public override string ToString()
        {
            return Nome 
                + ", R$" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " + Quantidade 
                + " unidade , Total : R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
