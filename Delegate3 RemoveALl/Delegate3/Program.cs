﻿using Delegate3.Entities;
class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));                
        //list.RemoveAll(p => p.Price >= 100.0
        list.RemoveAll(ProductTest);  //pode se usar assim tambem pois o predicate mesmo faz a validação de se
                                     //verdadeiro ou não        
        foreach (Product p in list)
        {
            Console.WriteLine(p);
        }
    }
    public static bool ProductTest(Product p)
    {
        return p.Price >= 100.0;
    }
}