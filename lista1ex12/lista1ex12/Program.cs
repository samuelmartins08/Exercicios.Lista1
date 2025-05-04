using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de 5 produtos em ordem: ");
            double prod1 = double.Parse(Console.ReadLine());
            double prod2 = double.Parse(Console.ReadLine());
            double prod3 = double.Parse(Console.ReadLine());
            double prod4 = double.Parse(Console.ReadLine());
            double prod5 = double.Parse(Console.ReadLine());

            double somprod = prod1 + prod2 + prod3 + prod4 + prod5;

            Console.WriteLine("O valor dos produtos é: {0}", somprod);
            Console.WriteLine("Digite a quantia em dinheiro que ira pagar: ");
            double pag = double.Parse(Console.ReadLine());

            double troco =  pag - somprod;

            Console.WriteLine("O valor do troco é: {0}", troco);

        }
    }
}
