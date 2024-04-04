
public class Banco
{

    public int Numero_conta { get; private set; }
    public string Nome { get; set; }
    public double Saldo { get; private set; }
    public Banco(int conta,string nome )
    {
        Numero_conta = conta;
        Nome = nome;
        
    }

    public Banco(int conta, string nome, double deposito)
    {
        Numero_conta = conta;
        Nome = nome;
        Saldo = deposito;    
    }

    public void deposito(double deposito)
    {
         Saldo += deposito;
    }
        
    
    public double Retirada (double saque)
    {
        return Saldo -= saque + 5.0;
    }

    public override string ToString()
    {
        return   " Conta " + Numero_conta +
                 " Titular : " + Nome +
                 " Saldo : $ " + Saldo.ToString("F2");
               
    }
}
