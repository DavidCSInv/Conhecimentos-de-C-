using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendaImposto.Entities
{
     class PessoaFisica : Taxa
    {

        public double HeathSpendings { get; set; }

        public PessoaFisica(string name, double income,double healthspendings): base(name,income)
        {
            HeathSpendings = healthspendings;
        }
        public override double Tax()
        {
            double TaxValue = 0.0;
            if (Income <= 20000 && HeathSpendings >0)
            {
               TaxValue += (Income * 0.15) - (HeathSpendings * 0.5);
            }
            else if (Income > 20000 && HeathSpendings > 0)
            {
                TaxValue += (Income * 0.25) - (HeathSpendings * 0.5) ;
            }
            return TaxValue;
        }
    }
}
