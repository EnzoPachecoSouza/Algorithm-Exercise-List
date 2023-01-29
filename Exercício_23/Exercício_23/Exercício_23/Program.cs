using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_23
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            Console.Write("Informe o valor de n: ");
            n = double.Parse(Console.ReadLine());

            if (n % 2 == 0) //if= se ...
            {
                Console.WriteLine("Este número é par");
                double par = Math.Pow(n, 2);
                Console.WriteLine($"O número par ao quadrado é: " + par);
            }
            else //caso contrário...
            {
                Console.WriteLine("Este número é impar");
                double impar = Math.Pow(n, 3);
                Console.WriteLine($"O número par ao quadrado é: " + impar);
            }

            Console.Read();
        }
    }
}
