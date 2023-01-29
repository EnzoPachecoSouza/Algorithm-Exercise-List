using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie um algoritmo que receba vários números inteiros digitados pelo usuário.
            //Estes números devem ser obrigatóriamente maior do que zero.
            //O algoritmo deve ser finalizado quando for digitado um número menor ou igual a zero.
            //Ao final o algoritmo deve informar qual foi o maior número digitado pelo usuário.

            int maiorNumero = 0;

            for (int i = 1; i > 0; i++)
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                if(numero > 0)
                {
                    if(numero > maiorNumero)
                    {
                        maiorNumero = numero;
                    }
                }

                else
                {
                    break;
                }
            }
            Console.WriteLine(" ");

            Console.WriteLine("O maior número é: " + maiorNumero);
        }
    }
}
