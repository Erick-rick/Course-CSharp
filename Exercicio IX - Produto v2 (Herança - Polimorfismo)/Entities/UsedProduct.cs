using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_IX___Produto_v2__Herança___Polimorfismo_.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureData) : base(name, price)
        {
            ManufactureDate = manufactureData;
        }

        public override string PriceTag() {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
