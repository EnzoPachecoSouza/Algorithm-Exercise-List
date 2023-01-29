using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_48
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            Console.Write("Digite um número maior que zero: ");
            int n = int.Parse(Console.ReadLine());


            if (n < 0)
            {
                Console.WriteLine("O número deve ser maior que zero");
            }

            else if (n > 0)
            {
                while (soma <= n)
                {
                    Console.WriteLine(soma);
                    soma++;
                }
            }

            Console.Read();
        }
    }
}
