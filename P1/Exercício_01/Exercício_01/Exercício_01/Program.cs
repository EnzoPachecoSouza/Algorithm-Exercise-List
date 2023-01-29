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
            Console.WriteLine("---> F2211490");
            Console.WriteLine("---> Exercício 01");
            Console.WriteLine("  ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  ");

            Console.Write("Digite um número que tenha no mínimmo 5 algarismos: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10000)
            {
                int milhar = (numero / 1000) % 10;

                Console.WriteLine(milhar);
            }

            else
            {
                Console.Write("ERRO!!! Digite um número que tenha no mínimmo 5 algarismos.");
            }

            Console.Read();
        }
    }
}
