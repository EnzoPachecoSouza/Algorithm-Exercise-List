using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_48_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 20;

            Console.Write("Digite um número menor que dez: ");
            int n = int.Parse(Console.ReadLine());


            if (n > 10)
            {
                Console.WriteLine("O número deve ser menor que dez");
            }

            else
            {
                while (aux >= n)
                {
                    Console.WriteLine(aux);

                    aux--;
                }
            }

            Console.Read();
        }
    }
}
