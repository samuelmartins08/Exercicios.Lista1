using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite a quantidade de milhas marítimas: ");
                double milhasMaritimas = double.Parse(Console.ReadLine());

                double metros = milhasMaritimas * 1852;
                double quilometros = metros / 1000;

                Console.WriteLine($"{milhasMaritimas} milhas marítimas equivalem a {quilometros:F3} km.");
            }
        }
    }
}


