using Delegates.CalculationService;
delegate double BinaryNumericOperation(double n1, double n2);
class program
{
    static void main(string[] args)
    {
        double a, b;
        a = 12;
        b = 10;

        //Este tipo de função sofre de TypeSafety ou seja se não atribuir algo que a mesma já foi atribuida
        // ira dar erro//
        //tambem não é necessario passar o que ela vai receber e sim só a operação dela//
        BinaryNumericOperation op = CalculationService.Sum;

        double maximo = op (a, b);
        double soma = op (a, b);
        Console.WriteLine(maximo);
        Console.WriteLine(soma);
    }
}