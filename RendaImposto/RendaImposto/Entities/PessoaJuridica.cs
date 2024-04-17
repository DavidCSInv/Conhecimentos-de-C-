using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendaImposto.Entities
{
    class PessoaJuridica : Taxa
    {
        public int Func {  get; set; }

        public PessoaJuridica (string name,double income,int func) : base(name,income)
        {
            Func = func;
        }
        public override double Tax()
        {
            double TaxValue = 0;
            if (Func > 10)
            {
                TaxValue += (Income * 0.14);
            }
            else
            {
                TaxValue += Income * 0.16;
            }

            return TaxValue;
        }
    }
}
