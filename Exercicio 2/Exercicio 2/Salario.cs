// See https://aka.ms/new-console-template for more information

public class Salario
{
    public string nome;
    public double salario;
    public double imposto;

    public double Salario_Liquido()

    {
        return salario - imposto;
    }

    public void Aumento(double Ajusta)
    {
        salario = salario + (salario *= Ajusta / 100);
    }

    public override string ToString()
    {
        return nome + 
            " $ "+ 
            Salario_Liquido().ToString("F2"); 
    }
}