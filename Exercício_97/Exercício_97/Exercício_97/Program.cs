using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_97
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números você deseja ler? ---> ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            int[] vetor = new int[quantidade];

            for(int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if(vetor[i] < 0)
                {
                    Console.WriteLine("Digite um número inteiro e positivo!!!");
                    i--;
                }
            }

            //----------------------------------------------------------- MÉDIA
            int soma = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }

            double media = soma / quantidade;

            //------------------------------------------------------------ MAIOR NÚMERO
            int maiorNumero = vetor[0];

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > maiorNumero)
                {
                    maiorNumero = vetor[i];
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("A média é: " + media);
            Console.WriteLine(" ");
            Console.WriteLine("O maior número é: " + maiorNumero);
        }
    }
}
