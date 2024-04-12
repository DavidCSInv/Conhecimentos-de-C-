using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PedidoTreino.Entities
{
     class CadProduto
    {
        public string Produto { get; set; }
        public double Preco { get; set; }
        public CadProduto() 
        {

        }

        public CadProduto(string produto,double preco)
        {
            Produto = produto;
            Preco = preco;
        }
    }
}
