// See https://aka.ms/new-console-template for more information

public class dolar
{
    public static double IOF = 6.0;

    public static double Multiplicador(double real,double dolar)
    {
        double multiplica = real * dolar;
        return multiplica + multiplica * IOF / 100;
    }
 
}
