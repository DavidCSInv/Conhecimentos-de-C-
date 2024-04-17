using RendaImposto.Entities;
using System.Diagnostics.CodeAnalysis;

List <Taxa> Taxa = new List<Taxa>();

Console.Write("Enter the number of tax payers:");
int Repete = Convert.ToInt32(Console.ReadLine());

for  (int i = 1; i <= Repete; i++)
{

    Console.WriteLine($"Tax paye{i}data");

    Console.Write("Individual or company (i/c)?");
    char pessoa = Convert.ToChar(Console.ReadLine());

    if (pessoa =='i')
    {
        Console.Write("Name: ");
        string Name = Console.ReadLine();

        Console.Write("Anual income:");
        double Income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Health expenditures:");
        double Health = Convert.ToDouble(Console.ReadLine());

        Taxa.Add(new PessoaFisica(Name, Income, Health));
    }
    else if (pessoa == 'c')
    {
        Console.Write("Name: ");
        string Name = Console.ReadLine();

        Console.Write("Anual income:");
        double Income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Number of Employees : ");
        int Func = Convert.ToInt32(Console.ReadLine());

        Taxa.Add(new PessoaJuridica(Name, Income, Func));
    }


}
Console.WriteLine("TAXES PAID:");

double somaTotal = 0;
foreach (Taxa taxas in Taxa)
{
    Console.WriteLine(taxas.ToString());
    somaTotal += taxas.Tax();
}

Console.WriteLine($"TOTAL TAXES: $ {somaTotal.ToString("F2")}");


