using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val1;
            double val2;
            double val3;
            double val4;
            double soma;
            double result;


            Console.WriteLine("Digite o primeiro valor: ");
            val1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            val2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            val3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            val4 = double.Parse(Console.ReadLine());

            soma = val1 + val2 + val3 + val4;
            result = soma / 4;

            Console.WriteLine("O valor da media aritimética é: {0}", result);


        }
    }
}
