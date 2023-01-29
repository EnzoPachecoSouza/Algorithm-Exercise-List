using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercíco_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---> Enzo Pacheco de Oliveira Souza");
            Console.WriteLine("---> ");
            Console.WriteLine("---> Exercício 02");
            Console.WriteLine("  ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  ");

            Console.Write("Digite o Limite Superior: ");
            int limiteSuperior = int.Parse(Console.ReadLine());

            Console.Write("Digite o Incremento: ");
            int incremento = int.Parse(Console.ReadLine());

            int inicial = 0;


            if (incremento > 0 && limiteSuperior > 0)
            {
                while (inicial <= limiteSuperior)
                {
                    Console.WriteLine(inicial);

                    inicial = inicial + incremento;
                }
            }

            else
            {
                Console.WriteLine("O incremento e o limite superior devem ser maior que zero");
            }
        }
    }
}
