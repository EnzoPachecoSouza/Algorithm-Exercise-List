using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_95
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de voltas: ");
            int quantidadeDeVoltas = int.Parse(Console.ReadLine());

            int[] array = new int[quantidadeDeVoltas];

            for(int i = 0; i < array.Length; i++)
            {
                int aux = i + 1;
                Console.Write("Digite o tempo da " + aux + "º volta: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int melhorVolta = array[0];
            int volta = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < melhorVolta)
                {
                    melhorVolta = array[i];
                    volta = i + 1;
                }
            }

            Console.WriteLine("O melhor tempo é: " + melhorVolta + " e ocorreu na " + volta + "º volta");
        }
    }
}
