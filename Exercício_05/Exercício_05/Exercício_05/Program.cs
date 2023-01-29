using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0, d = 0, e = 0;
            Console.Write("Informe o valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de c: ");
            c = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de d: ");
            d = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de e: ");
            e = double.Parse(Console.ReadLine());

            double soma = a + b + c + d + e;

            Console.WriteLine("Os números digitados foram: " + a + ", " + b + ", " + c + ", " + d + ", " + e + " e sua soma é: " + soma);

            Console.Read();
        }
    }
}
