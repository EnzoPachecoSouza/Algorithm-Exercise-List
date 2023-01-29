using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;
            Console.Write("Informe o valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de c: ");
            c = double.Parse(Console.ReadLine());

            double vol = a * b * c;

            Console.WriteLine("O volume do paralelepípedo é: " + vol);

            Console.Read();
        }
    }
}
