using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{

    public class Funcionario
    {
        static void Main(string[] args)
        {
            Salario func = new Salario();

            Console.Write("Nome :");
            func.nome = Console.ReadLine();

            Console.Write("Salario Bruto :");
            func.salario = Convert.ToDouble (Console.ReadLine());

            Console.Write("Imposto :");
            func.imposto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Funcionario : {func}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");

            double perc = Convert.ToDouble(Console.ReadLine());

            func.Aumento(perc);

            Console.WriteLine($"Dados Atualizados : {func}");

        }
    }
}
