using Delegate2.Services;

delegate void BinaryNumericOperation(double n1, double n2);
class Program
{
    static void Main(string[] args)
    {
        //Para um Delegate receber mais de uma função não faz sentido pedir tudo volte então ele é void
        // Tambem pode-se atribuir mais de uma metodo para ele so adicionar += a ele e o seu metodo
        double a = 10;
        double b = 12;
        BinaryNumericOperation op = CalculationService.ShowSum;
        op += CalculationService.ShowMax;
        op(a, b);
    }
}