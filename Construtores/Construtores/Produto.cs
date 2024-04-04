// See https://aka.ms/new-console-template for more information
namespace Produto_Estoque
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //isso é uma sobrecarga você pode colocar o mesmo parametros mais de uma vez !
        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
         }

        public double ValorEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }


        public void RemoverEstoque(int quantidade)
        {
            Quantidade -= quantidade;
        }
        //mETODO DE HERANÇA DE OVERRIDEp
        public override string ToString()
        {
            return Nome +
                ", $" + Preco.ToString("F2") +
                ", " + Quantidade +
                "Unidade, Total : $ "
                + ValorEmEstoque().ToString("F2");
        }
    }
}