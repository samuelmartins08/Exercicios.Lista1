using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dolar no dia 04/05/2025
            double dolar = 5.66;
            Console.WriteLine("Digite o valor em dolares: ");
            double val1 = double.Parse(Console.ReadLine());

            double mult = dolar * val1;
            Console.WriteLine("O valor em Reais é: {0}", mult);
        }
    }
}
