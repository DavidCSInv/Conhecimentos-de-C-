using Produto_Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    static void Main(string[] args)
    {

        Produto p = new Produto("TV", 500.00, 10);


        p.SetNome("TV 4K");

        Console.WriteLine(p.GetNome());
        Console.WriteLine(p.GetPreco());
        Console.WriteLine(p.GetQuantidade());
    }
}
