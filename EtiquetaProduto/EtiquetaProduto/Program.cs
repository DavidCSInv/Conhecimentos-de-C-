
using EtiquetaProduto.Entities;

List<Product> products = new List<Product>();

Console.Write("Enter the number of products:");

short repete = Convert.ToSByte(Console.ReadLine());

for (int i = 1; i <=repete; i++)
{
    Console.WriteLine($"Product #{i} data");
    Console.Write("Common, used or imported (c/u/i)?");

    char Tipo = Convert.ToChar(Console.ReadLine());

    Console.Write("Name : ");
    string Name = Console.ReadLine();

    Console.Write("Price : ");
    double price = Convert.ToDouble(Console.ReadLine());

    Product product = new Product(Name,price);

    if ( Tipo == 'i' || Tipo == 'I')
    {
        Console.Write("Custom fee : ");
        double Fee = Convert.ToDouble(Console.ReadLine());
        products.Add(new ImportedProduct(Name, price, Fee));
    }
    else if ( Tipo == 'u' || Tipo =='U')
    {
        Console.Write("Manufacture date (DD/MM/YYYY) : ");
        DateTime data = Convert.ToDateTime(Console.ReadLine());
        products.Add(new UsedProducts(Name, price, data));
    }
    else
    {
        products.Add(product);
    }
}
Console.WriteLine();
Console.WriteLine("Price Tags :");

foreach (Product prod in products)
{
    Console.WriteLine(prod.PriceTag());
}
