using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0, soma = 0, quantidade = 0, media = 0,quantidadePositiva = 0, somaPositiva = 0, quantidadeNegativa = 0, somaNegativa =0,

            do
            {
                Console.WriteLine("---> Enzo Pacheco de Oliveira Souza");
                Console.WriteLine("---> ");
                Console.WriteLine("---> Exercício 03");
                Console.WriteLine("  ");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("  ");

                Console.Write("Digite um número: ");
                n = double.Parse(Console.ReadLine());

                if (n > 0)
                {
                    quantidadePositiva++;

                    somaPositiva += n;
                }

                else if (n < 0)
                {
                    quantidadeNegativa++;

                    somaNegativa += n;
                }

                soma = somaPositiva + somaNegativa;

                quantidade = quantidadePositiva + quantidadeNegativa;

                media = soma / quantidade;
            } while (n != 0);

            Console.WriteLine("A quantidade de múmeros positivos é: " + quantidadePositiva);
            Console.WriteLine("A quantidade de números negativos é: " + quantidadeNegativa);
            Console.WriteLine("A média dos números digitados é: " + media);

            Console.Read();
        }
    }
}
