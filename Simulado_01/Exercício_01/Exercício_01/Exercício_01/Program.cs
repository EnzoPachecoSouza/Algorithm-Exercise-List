using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---> Enzo Pacheco de Oliveira Souza");
            Console.WriteLine("---> ");
            Console.WriteLine("---> Exercício 01");
            Console.WriteLine("  ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  ");

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int dezena = numero / 10 % 10;

            if (numero >= 10)
            {
                Console.WriteLine(dezena);
            }

            else
            {
                Console.WriteLine("O número deve ser igual ou maior que dez");
            }
        }
    }
}
