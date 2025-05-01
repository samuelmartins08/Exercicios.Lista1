using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());
           
            double mediaGeometrica = Math.Sqrt(valor1 * valor2);

            Console.WriteLine($"A média geométrica dos valores é: {mediaGeometrica:F2}");
        

           
        }
    }
}
