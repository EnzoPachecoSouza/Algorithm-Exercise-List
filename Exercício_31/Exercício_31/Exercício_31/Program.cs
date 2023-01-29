using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_31
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

            double soma = Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2);

            if (soma % 2 == 0)
            {
                Console.WriteLine("A soma dos quadrados dosnúmeros " + a + ", " + b + " e " + c + " , é par!");
            }
            else if (soma % 2 == 1)
            {
                Console.WriteLine("A soma dos quadrados dos números " + a + ", " + b + " e " + c + " , é impar!");
            }
            else
            {

            }

            Console.Read();
        }
    }
}
