using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_89
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números você quer digitar? ");
            int tamanho = int.Parse(Console.ReadLine());

            Console.Clear();

            int[] numero = new int[tamanho];

            for(int i = 0; i < numero.Length; i++)
            {
                Console.Write("Digite um número: ");
                numero[i] = int.Parse(Console.ReadLine());
            }

            for(int i = tamanho - 1; i >= 0; i--) //TAMANHO - 1 (para começar na posição correta)
            {
                Console.WriteLine(numero[i]);
            }
        }
    }
}
