using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---> Enzo Pacheco de Oliveira Souza");
            Console.WriteLine("---> F2211490");
            Console.WriteLine("---> Exercício 03");
            Console.WriteLine("  ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  ");

            int n = 1;
            int quantidade = 0;
            int quantidadeMult5 = 0;
            int soma = 0;


            do
            {
                Console.Write("Digite um número: ");
                n = int.Parse(Console.ReadLine());

                if (n >= 0)
                {
                    quantidade++;

                    if (n % 5 == 0)
                    {
                        quantidadeMult5++;
                    }

                    if ((n % 2 != 0) || (n % 5 == 0))
                    {
                        soma += n;
                    }
                }

                else
                {
                    Console.WriteLine("Você encerrou o código!");
                }

            } while (n >= 0);

            Console.WriteLine("Quantidade de números digitados: " + quantidade);
            Console.WriteLine("Quantidade de números multiplos de 5: " + quantidadeMult5);
            Console.WriteLine("Soma: " + soma);

            Console.Read();
        }
    }
}
