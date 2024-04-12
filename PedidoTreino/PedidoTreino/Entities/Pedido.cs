using PedidoTreino.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace PedidoTreino.Entities
{
    class Pedido
    {
        public DateTime Moment { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public List<PedidoItem> ItemPreco { get; set; } = new List<PedidoItem>();
        public Cliente Cliente { get; set; }

        public Pedido()
        {

        }
        public Pedido(DateTime moment, StatusPedido statuspedido,Cliente cliente)
        {
            Moment = moment;
            StatusPedido = statuspedido;
            Cliente = cliente;
        }

        public void AddQuantidade(PedidoItem quantidade)
        {
            ItemPreco.Add(quantidade);
        }

        public void RemoveQuantidade(PedidoItem quantidade)
        {
            ItemPreco.Remove(quantidade);
        }

        public double TotalPed()
        {
            double total = 0.0;

            foreach (PedidoItem item in ItemPreco)
            {
              
                total += item.SubTotal();

            }
            return total;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order Moment :" + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine($"Order Status : {StatusPedido.ToString()}");
            sb.AppendLine($"Client : {Cliente.ToString()}");
            sb.AppendLine("Order Itens :");            

            foreach (PedidoItem item in ItemPreco) 
            { sb.AppendLine(item.ToString()); }
            
            sb.AppendLine("Total : " + TotalPed().ToString("F2"));

            return sb.ToString();

        }

    }
}

