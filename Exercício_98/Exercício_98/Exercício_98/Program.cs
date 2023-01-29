using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_98
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[5];

            for (int i = 0; i < numero.Length; i++)
            {
                Console.Write("Digite um número: ");
                numero[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");

            //--------------------------------------------------------> SOMA
            int soma = 0;

            for(int i = 0; i < numero.Length; i++)
            {
                soma += numero[i];
            }

            Console.WriteLine("A soma dos números digitados é: " + soma);

            Console.WriteLine(" ");

            //--------------------------------------------------------> AMOSTRA DOS NÚMEROS POR LINHA 
            Console.WriteLine("Os números que o usuário digitou foram: ");

            Console.WriteLine(" ");

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine(numero[i]);
            }
        }
    }
}
