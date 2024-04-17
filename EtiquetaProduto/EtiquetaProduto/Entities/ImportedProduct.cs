using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaProduto.Entities
{
    class ImportedProduct : Product
    {
        public double ImportedFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double importedfee) : base(name, price)
        {
            ImportedFee = importedfee;
        }

        public double TotalPrice () 
        {
            return Price + ImportedFee;
        }

        public override string PriceTag()
        {
            return Name 
                + " $"
                + TotalPrice().ToString()
                + $" (Custom fee : $ {ImportedFee})";
        }
    }
}
