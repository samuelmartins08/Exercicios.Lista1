using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de X: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valore de Y: ");
            double y = double.Parse(Console.ReadLine());

            double elev = Math.Pow(x, y);

            Console.WriteLine("O resultado de {0} elevado a {1} é: {2}", x, y, elev);
        }
    }
}
