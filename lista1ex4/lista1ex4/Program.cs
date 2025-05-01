using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baze;
            double alt;
            double area;


            Console.WriteLine("Digite o valor da base: ");
            baze = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura: ");
            alt = double.Parse(Console.ReadLine());

            area = baze * alt;

            Console.WriteLine("Calculando a area do triangulo utilizando a altura e base, temos: {0} ", area);




        }
    }
}
