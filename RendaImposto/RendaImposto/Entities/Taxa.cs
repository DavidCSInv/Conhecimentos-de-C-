using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendaImposto.Entities
{
    abstract class Taxa
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Taxa(string name,double income) 
        { 
            Name = name;
            Income = income;
        }

        public abstract double Tax();
        public override string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2");
        }

    }
}
