using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_26
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            Console.Write("Informe o valor de a: ");
            a = double.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Este número é par");
            }
            else
            {
                Console.WriteLine("Este número é impar");
            }

            Console.Read();
        }
    }
}
