using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_de_CLASSE
{
    public class Program
    {
        static void Main (string[] args)
        {


            parametros x = new parametros();

            Console.WriteLine("Entre a largura e altura do retângulo: ");

            x.Largura = Convert.ToDouble(Console.ReadLine());
            
            x.Altura = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"Area = " + x.Area().ToString("F2"));
            Console.WriteLine($"Perimetro = " + x.Perimetro().ToString("F2"));
            Console.WriteLine($"Diagonal = " + x.Diagonal().ToString("F2"));

        }
    }
}
