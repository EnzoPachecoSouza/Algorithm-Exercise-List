using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_29
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
            double raizCubica = Math.Pow(soma, 3);

            if (soma > 10)
            {
                Console.WriteLine("Os números digitados foram: " + a + " e " + b);
                Console.WriteLine("O valor da soma dos números digitados é: " + soma);
                Console.WriteLine("A raiz cubida dessa adição é: " + raizCubica);
            }
            else
            {
                Console.WriteLine("Os números digitados foram: " + a + " e " + b);
                Console.WriteLine("O valor da soma dos números digitados é: " + soma);
            }

            Console.Read();
        }
    }
}
