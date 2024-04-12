// See https://aka.ms/new-console-template for more information

using EXERCICIO_DE_ENUMS.Entities;
using EXERCICIO_DE_ENUMS.Entities.Enums;

Console.Write("Enter Deparment's name :");
string deptName = Console.ReadLine();

Console.WriteLine ("Worker data : ");
Console.Write("Name :");
string name = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senio) : ");

WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base Salary : ");
double baseSalary = double .Parse(Console.ReadLine());

Department dept = new Department(deptName);

Worker worker = new Worker(name,level,baseSalary,dept);

Console.WriteLine("How many contracts to this worker ? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} contract data :");
    Console.Write("Date (DD/MM/YYYY) : ");
    DateTime date = DateTime.Parse(Console.ReadLine());

    Console.Write("Value per Hour : ");
    double valuePerHour = double.Parse(Console.ReadLine());

    Console.Write( "Duration (hours) : ");
    int hours = int.Parse(Console.ReadLine());

    Hourcontract contratct = new Hourcontract(date,valuePerHour,hours);

    worker.AddContract(contratct);

}
Console.WriteLine();
Console.Write("Enter month and year to calculate the income (MM/YYYY) :");
string monthAndYear = Console.ReadLine();

int month = int.Parse(monthAndYear.Substring(0, 2));
int year =  int.Parse(monthAndYear.Substring(3));

Console.WriteLine($"Name {name}");
Console.WriteLine($"Departmen {worker.Department.Name}");
Console.WriteLine($"Income for {monthAndYear} : {worker.Income(year,month)}");



