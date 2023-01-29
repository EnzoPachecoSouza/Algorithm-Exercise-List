using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];

            int[] vetor2 = new int[10];


            //---------------------------------------------------------> VETOR 1
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");
            //---------------------------------------------------------> VETOR 2

            for (int i = 0; i < 10; i++)
            {
                vetor2[i] = vetor1[i] * 5;
            }

            //---------------------------------------------------------> AMOSTRA DO VETOR 1
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vetor1[i]);
            }

            Console.WriteLine(" ");
            //---------------------------------------------------------> AMOSTRA DO VETOR 2
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vetor2[i]);
            }
        }
    }
}
