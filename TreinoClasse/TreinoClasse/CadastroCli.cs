using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoClasse
{
    public class CadastroCli

    {
        static void Main(string[] args)
        {

            Banco conta;

            Console.Write("Entre o número da conta: ");
            int numero_conta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre o titular da conta:");
            string cliente = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = Convert.ToChar(Console.ReadLine());


            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre o valor de depósito inicial:");
                double receb_inic = Convert.ToDouble(Console.ReadLine());

                 conta = new Banco(numero_conta, cliente, receb_inic);
            }
            
            else 
            {
                conta = new Banco(numero_conta, cliente);
            }

            Console.WriteLine("Dados da Conta");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para depósito: ");
            Double Deposito  = Convert.ToDouble(Console.ReadLine());
            conta.deposito(Deposito);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque : ");
            Double retirada = Convert.ToDouble(Console.ReadLine());
            conta.Retirada(retirada);

            Console.Write("Dados da conta atualizados:");
            Console.WriteLine(conta);

        }
    }
}
