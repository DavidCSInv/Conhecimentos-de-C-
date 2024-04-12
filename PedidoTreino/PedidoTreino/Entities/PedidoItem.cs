using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoTreino.Entities
{
    class PedidoItem
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public CadProduto Produto { get; set; }

        public PedidoItem()

        {

        }

        public PedidoItem(int quantidade, double preco, CadProduto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return  Produto.Produto 
                   + ", $"
                   + Preco 
                   + ", Quantity "
                   + Quantidade
                   + ",Subtotal " + SubTotal().ToString("F2");
        }
    }
}
