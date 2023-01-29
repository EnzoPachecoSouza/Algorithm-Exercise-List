using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_81
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                double numero = double.Parse(Console.ReadLine());

                double metade = numero / 2;

                Console.WriteLine("A metade de " + numero + " é: " + metade);

                Console.WriteLine(" ");
            }
        }
    }
}
