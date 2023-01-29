using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_96
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite no máximo 50 números.");

            Console.WriteLine(" ");

            int[] vetor = new int[50];

            for(int i = 0; i < 50; i++)
            {
                Console.Write("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if(vetor[i] < 0)
                {
                    Console.Write("Digite um número inteiro maior que zero!!!");
                    i--;

                    Console.WriteLine(" ");
                }
            }

            int quantidadePares = 0;
            int quantidadeMultiplosDe5 = 0;

            for (int i = 0; i < 50; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    quantidadePares++;
                }
            }

            for (int i = 0; i < 50; i++)
            {
                if (vetor[i] % 5 == 0)
                {
                    quantidadeMultiplosDe5++;
                }
            }

            Console.WriteLine(" ");

            Console.WriteLine("A quantidade de números pares é: " + quantidadePares);
            Console.WriteLine("A quantidade de números multiplos de 5 é: " + quantidadeMultiplosDe5);
        }
    }
}
