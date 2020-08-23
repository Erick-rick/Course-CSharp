using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Exercicio_IX___Produto_v2__Herança___Polimorfismo_.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag (){
            return Name
              + " $ "
              + Price.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
