using DelegateSelectFunc.Entities;
using System;

class program
{
    static void Main(String[] args)

    {

        List<Product> products = new List<Product>();

        products.Add(new Product("TV", 900.00));
        products.Add(new Product("Banana", 10.00));
        products.Add(new Product("Sabao", 2.00));
        products.Add(new Product("Bala", 1.00));

        //List<string> result = products.Select(NameUpper).ToList(); -- metodo numero 1
        //
        //Versao 2
        //Func<Product, string> func = p => p.Name.ToUpper();

        //List<string> result = products.Select(func).ToList();
        List<string> result = products.Select(p=>p.Name.ToUpper()).ToList();
        foreach (string item in result)
            Console.WriteLine(item);

    }

    //static string NameUpper (Product p)
    //{
    //    return p.Name.ToUpper();
    //}
}