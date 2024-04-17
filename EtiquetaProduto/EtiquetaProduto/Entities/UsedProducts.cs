using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaProduto.Entities
{
     class UsedProducts : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProducts ()
        {

        }

        public UsedProducts (string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (Used) " + Price + $" (Manufacture Date :{ManufactureDate}) ";
        }

    }
}
