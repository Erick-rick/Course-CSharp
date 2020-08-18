using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Text;

namespace Construtores
{
    class Produto
    {
        /// <Ordem_de_implementação >
        /// atributos privados
        /// Propriedades autoimlementadas
        /// Construtores
        /// Propriedades customizadas
        /// Outros métodos de classe
        /// </summary>

        private string _nome;

        //auto-Properties  - Não possui uma logica por tras == igual a _nome
        public double Preco { get; private set; }
        public int Quantidade { get; set; }

        //Construtor
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }
        //Sobrecarga -> com 2 paramentros
        public Produto(string nome, double preco) {
            _nome = nome;
            Preco = preco;

        }
        //Construtor Padrao sem argumentos
        public Produto()
        {

        }

        //Metodo get e set
        /*public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            if(nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }*/

        //Properties - implementa o metodo get e set
        public string Nome
        {
            get { return _nome; }
            set {  // value -> referencia ao proprio atributo == nome 
                if(value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        /*
         * // Properties 
        public double Preco {
            get { return _preco; }

        }
        // Properties 
        public int Quantidade {

            get { return _quantidade; }
        }
        */


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }


}