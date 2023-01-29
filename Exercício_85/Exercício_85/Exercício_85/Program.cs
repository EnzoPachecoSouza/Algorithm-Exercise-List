using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_85
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros ira imprimir: ");

            int tamanho = int.Parse(Console.ReadLine());

            for(int i = 1; i <= (tamanho * 2); i++) //(tamanho * 2) para fazer com que chegue até o número digitado
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
