using TryCatch_Exceptions_Exercicio.Entities;

namespace TryCatch_Exceptions_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number : ");
                short Number = Convert.ToSByte(Console.ReadLine());

                Console.Write("Holder : ");
                string Holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double Balance = Convert.ToDouble(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                double Withdrawlimit = Convert.ToDouble(Console.ReadLine());

                Account account = new Account (Number, Holder, Balance, Withdrawlimit);

                Console.WriteLine("Enter amount for withdraw: ");
                double Withdraw = Convert.ToDouble(Console.ReadLine());

                account.Withdraw(Withdraw);

                Console.WriteLine(account);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Withdraw error:" + ex.Message);
            }
    


        }
    }
}