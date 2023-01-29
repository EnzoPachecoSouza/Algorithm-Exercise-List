using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_38
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            Console.Write("Informe o valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de b: ");
            b = double.Parse(Console.ReadLine());

            double soma = a + b;
            double raizCub = Math.Pow(soma, 1.0 / 3.0); 

            if (soma > 10)
            {
                Console.WriteLine("Os números digitados foram: " + a + " e " + b);
                Console.WriteLine("A soma de " + a + " + " + b + " é: " + soma);
                Console.WriteLine("A raiz cúbica de " + soma + " é: " + raizCub);
            }
            else
            {
                Console.WriteLine("Os números digitados foram: " + a + " e " + b);
                Console.WriteLine("A soma de " + a + " + " + b + " é: " + soma);
            }

            Console.Read();
        }
    }
}
