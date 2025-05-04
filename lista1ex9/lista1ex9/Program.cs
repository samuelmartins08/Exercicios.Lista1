using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do diametro: ");
            double diam = double.Parse(Console.ReadLine());
            
            double pi = 3.14159;

            double diam2 = diam / 2;
            double area = pi * diam2 * diam2;

            Console.WriteLine("A area calculada é: {0}", area);
           
        }
    }
}
