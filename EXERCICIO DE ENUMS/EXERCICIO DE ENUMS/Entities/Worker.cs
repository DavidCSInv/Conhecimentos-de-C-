using EXERCICIO_DE_ENUMS.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_DE_ENUMS.Entities
{
     class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public List<Hourcontract> Contracts { get; set; } = new List<Hourcontract>();

        public Worker()
        {

        }

        public Worker (string name,WorkerLevel level,double baseSalary,Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(Hourcontract contract)
        {
            Contracts.Add(contract);
        }     
        
        public void RemoveContract(Hourcontract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            foreach (Hourcontract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }

}
