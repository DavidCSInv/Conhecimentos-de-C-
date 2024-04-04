using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEstaticos
{
    public class Cotação
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dólar ?");
            double dol = Convert.ToDouble(Console.ReadLine());  
            
            Console.Write("Quantos dólares você vai comprar?");
            double rel = Convert.ToDouble(Console.ReadLine());

            double soma = dolar.Multiplicador(dol, rel);

            Console.WriteLine("Valor a ser pago em reais = " + soma.ToString("F2"));

        }
    }
}
