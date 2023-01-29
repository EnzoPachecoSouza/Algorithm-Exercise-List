using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_109
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            int quantidadeEmBranco = 0;

            Console.WriteLine(" ");

            Console.WriteLine("A FRASE ---> " + frase);

            Console.WriteLine(" ");

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    quantidadeEmBranco++;
                }
            }

            Console.WriteLine(" ");

            Console.WriteLine("A quantidade de espaços em branco é de: " + quantidadeEmBranco);
        }
    }
}
