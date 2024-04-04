// See https://aka.ms/new-console-template for more information
public class nota
{
    public string nome;
    public double prova1;
    public double prova2;
    public double prova3;

    public double soma ()
    {
        return prova1 + prova2 + prova3;
    }

    public double reprova()
    {
        return 60 - (prova1 + prova2 + prova3) ;
    }
}