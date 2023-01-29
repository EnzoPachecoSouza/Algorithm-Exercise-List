using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_102
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];

            int[] vetor2 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                vetor1[i] = int.Parse(Console.ReadLine());

                if(vetor1[i] == 0)
                {
                    Console.WriteLine("Digite um número que não seja zero!!!");
                    i--;
                }
            }

            Console.WriteLine(" ");

            //--------------------------------------------------------> VETOR 1
            Console.WriteLine("---> VETOR 1 (Pares)");

            for (int i = 0; i < 10; i++)
            {
                if (vetor1[i] % 2 == 0)
                {
                    Console.WriteLine(vetor1[i]);
                }

                else
                {
                    Console.WriteLine("0");
                }
            }

            Console.WriteLine(" ");

            //--------------------------------------------------------> VETOR 2
            Console.WriteLine("---> VETOR 2 (Impares)");

            for (int i = 0; i < 10; i++)
            {
                vetor2[i] = vetor1[i];

                if (vetor2[i] % 2 != 0)
                {
                    Console.WriteLine(vetor2[i]);
                }

                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
