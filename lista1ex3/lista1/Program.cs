using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diagonal;
            double area;

            Console.Write("Informe o valor da diagonal: ");
            diagonal = double.Parse(Console.ReadLine());
           

            area = (diagonal * diagonal) / 2;

            Console.WriteLine("O valor da area é: {0}", area);


             


            
        }
    }
}
