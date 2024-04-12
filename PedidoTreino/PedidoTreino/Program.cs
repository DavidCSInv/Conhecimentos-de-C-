using PedidoTreino.Entities;
using PedidoTreino.Entities.Enums;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Client Data : ");

        Console.Write("Name : ");
        string name = Console.ReadLine();

        Console.Write("Email : ");
        string email = Console.ReadLine();

        Console.Write("Birth date (dd/MM/yyyy) : ");
        DateTime data = Convert.ToDateTime(Console.ReadLine());

        Cliente cliente = new Cliente(name, email, data);

        Console.WriteLine("Enter order data: ");

        Console.Write("Status: ");
        StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

        DateTime DataPedido = DateTime.Now;
        
        Pedido Ordempedido = new Pedido (DataPedido, status,cliente);

        Console.Write("How many items to this order? ");
        int QPedidos = int.Parse(Console.ReadLine());


        for (int i = 0; i < QPedidos; i++)
        {
            Console.WriteLine($"Enter {i + 1} item data");

            Console.Write("Product name : ");
            string ProductName = Console.ReadLine();

            Console.Write("Product price : ");
            double ProductPrice = double.Parse(Console.ReadLine());            
            
            Console.Write("Quantity : ");
            int Quantity = int.Parse(Console.ReadLine());

            CadProduto cadProduto = new CadProduto(ProductName, ProductPrice);
            
            PedidoItem pedidoItem = new PedidoItem(Quantity,ProductPrice,cadProduto);

            Ordempedido.AddQuantidade(pedidoItem);
        }

        Console.WriteLine();

        Console.WriteLine("ORDER SUMMARY: ");

        Console.WriteLine(Ordempedido);


    }
}