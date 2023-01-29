using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de n1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de n2: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = 0;


            if (n1 > 0)
            {
                while (n1 <= n2)
                {
                    if (n1 % 2 == 0)
                    {
                        soma = soma + n1;
                        n1++;

                        Console.WriteLine(soma);
                    }

                    else
                    {
                        n1++;
                    }
                }
            }

            else
            {
                Console.WriteLine("Digite um número maior que zero, pois zero é um número neutro!");
            }
        }
    }
}
