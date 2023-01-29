using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho: ");
            int tamanho = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            int[] vetor1 = new int[tamanho];

            int[] vetor2 = new int[tamanho];

            int valoresIguais = 0;

            Console.WriteLine("VETOR 1");

            Console.WriteLine(" ");

            for(int i = 0; i < tamanho; i++)
            {
                Console.Write("Digite um número: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");

            Console.WriteLine("VETOR 2");

            Console.WriteLine(" ");

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Digite um número: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < tamanho; i++)
            {
                if(vetor1[i] == vetor2[i])
                {
                    valoresIguais++;

                    Console.WriteLine(" ");

                    Console.WriteLine("Os valores iguais se encontram na posição: " + i);
                }
            }

            Console.WriteLine(" ");

            Console.WriteLine("Se repetem valores iguais " + valoresIguais + " vezes");
        }
    }
}
