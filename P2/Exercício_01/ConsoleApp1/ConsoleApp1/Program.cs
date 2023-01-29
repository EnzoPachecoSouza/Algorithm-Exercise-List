using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---> Enzo Pacheco de Oliveira Souza");
            Console.WriteLine("---> F2211490");
            Console.WriteLine("---> Exercício 01");
            Console.WriteLine("  ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  ");

            int[] numero = new int[10];

            int quantidadeDePares = 0;

            int quantidadeDeImpares = 0;

            int maiorNumero = int.MinValue; ;

            int menorNumero = int.MaxValue;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                numero[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");

            //-----------------------------------------------> SEQUÊNCIA UM DO LADO DO OUTRO
            for (int i = 0; i < 10; i++)
            {
                Console.Write(numero[i] + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //-----------------------------------------------> QUANTIDADE DE PARES
            for (int i = 0; i < 10; i++)
            {
                if(numero[i] % 2 == 0)
                {
                    quantidadeDePares++;
                }
            }

            Console.WriteLine("A quantidade de números pares é: " + quantidadeDePares);

            Console.WriteLine(" ");           

            //-----------------------------------------------> QUANTIDADE DE IMPARES
            for (int i = 0; i < 10; i++)
            {
                if (numero[i] % 2 != 0)
                {
                    quantidadeDeImpares++;
                }
            }

            Console.WriteLine("A quantidade de números impares é: " + quantidadeDeImpares);

            Console.WriteLine(" ");

            //-----------------------------------------------> MAIOR NÚMERO
            for (int i = 0; i < 10; i++)
            {
                if (numero[i] < menorNumero)
                {
                    menorNumero = numero[i];
                }
                else if (numero[i] > maiorNumero)
                {
                    maiorNumero = numero[i];
                }
            }

            Console.WriteLine("O maior número digitado foi: " + maiorNumero);

            Console.WriteLine(" ");

            Console.WriteLine("O menor número digitado foi: " + menorNumero);
        }
    }
}


