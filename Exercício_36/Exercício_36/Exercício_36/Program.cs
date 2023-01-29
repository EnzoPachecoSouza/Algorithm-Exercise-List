using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_36
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 0;
            Console.Write("Informe o valor do produto: ");
            p = double.Parse(Console.ReadLine());

            double desconto = p * 0.09;
            double novoPreco = p - desconto;

            if (p <= 0)
            {
                Console.WriteLine("Valor Inválido");
            }
            else
            {
                Console.WriteLine("O valor atual do produto com desconto de 9% é: " + novoPreco);
            }

            Console.Read();
        }
    }
}
