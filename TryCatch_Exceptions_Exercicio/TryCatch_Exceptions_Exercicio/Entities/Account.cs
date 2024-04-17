using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Exceptions_Exercicio.Entities
{
    class Account
    {
        public int Number {  get; set; }

        public string Holder { get; set; }

        public double Balance { get; set; }

        public double WithDrawLimit {  get; set; }


        public Account(int number, string holder,double balance,double withdrawlimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withdrawlimit;

            throw new FormatException("Foi digitado o formato incorreto na aplicação");
        }

        public void deposit ()
        {
            double amount = 0;            
            Balance += amount;
        }

        public void Withdraw(double amount)
        {

            if (amount > WithDrawLimit)
            { 
                throw new DivideByZeroException("The amount exceeds withdraw limit");
            }
            else if (Balance < amount)
            {
                throw new DivideByZeroException("Not Enough Balance");
            }
            else
            {
                Balance -= amount;
            }

            
        }

        public override string ToString()
        {
            return "New Balance : " + Balance;
        }
    }
}
