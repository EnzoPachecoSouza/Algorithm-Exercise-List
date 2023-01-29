using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---> Enzo Pacheco de Oliveira Souza");
            Console.WriteLine("---> F2211490");
            Console.WriteLine("---> Exercício 02");
            Console.WriteLine("  ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  ");

            Console.Write("Digite o Limite Inferior: ");
            int limiteInferior = int.Parse(Console.ReadLine());

            Console.Write("Digite o Incremento: ");
            int incremento = int.Parse(Console.ReadLine());


            if (incremento > 0 && limiteInferior > 10)
            {
                while (limiteInferior >= 10)
                {
                    Console.WriteLine(limiteInferior);

                    limiteInferior = limiteInferior - incremento;
                }
            }

            else
            {
                Console.WriteLine("O incremento deve ser maior que zero e o Limite Inferior maior que 10");
            }

            Console.Read();
        }
    }
}
