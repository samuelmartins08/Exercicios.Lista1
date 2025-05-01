using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor em Celsius: ");
            double cels = double.Parse(Console.ReadLine());

            double mult = cels * 1.8;
            double result = mult + 32;

            Console.WriteLine("O valor em fahrenheit é: {0}", result);


        }
    }
}
