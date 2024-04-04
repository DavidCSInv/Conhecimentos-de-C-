using Produto_Estoque;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Entre os dados do produto : ");
        Console.Write("Nome :");
        String nome = Console.ReadLine();
        
        Console.Write("Preço :");
        double preco = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Quantidade :");
        int Quantidade = Convert.ToInt32(Console.ReadLine());


        Produto p = new Produto(nome, preco, Quantidade);


        Console.WriteLine($"Dados do Produto : {p}");

        Console.WriteLine("Digite o numero de estoque a ser atualizado : ");
        int qte = Convert.ToInt32(Console.ReadLine());
        p.AdicionarEstoque(qte);
        Console.WriteLine($"Estoque atualizado : {p}");

        Console.WriteLine("Digite o numero de estoque a ser removido : ");
        qte = Convert.ToInt32(Console.ReadLine());
        p.RemoverEstoque(qte);
        Console.WriteLine($"Estoque atualizado : {p}");
        
    }
}