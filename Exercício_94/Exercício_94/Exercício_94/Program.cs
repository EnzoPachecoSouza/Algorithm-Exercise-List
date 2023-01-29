using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_94
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int quantidade = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um Número: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if(vetor[i] == -1)
                {
                    i = vetor.Length;

                    Console.WriteLine(" ");
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] == 1 && vetor[i + 1] == 3 && vetor[i + 2] == 4)
                {
                    quantidade++;
                }
            }

            Console.WriteLine("A quantidade é: " + quantidade);
            Console.Read();
        }
    }
}
