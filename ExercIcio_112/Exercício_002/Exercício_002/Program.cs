using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que leia uma frase qualquer digitada pelo usuário e 
            //imprima a quantidade de consoantes que a frase possui.

            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine().ToUpper();

            int quantidadeDeConsoantes = 0;

            int quantidadeDeVogais = 0;

            int quantidadeDeEspacos = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ' && frase[i] != ',' && frase[i] != 'A' && frase[i] != 'E' && frase[i] != 'I' && frase[i] != 'O' && frase[i] != 'U')
                {
                    quantidadeDeConsoantes++;
                }
            }

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ' && frase[i] == 'A' || frase[i] == 'E' || frase[i] == 'I' || frase[i] == 'O' || frase[i] == 'U')
                {
                    quantidadeDeVogais++;
                }
            }

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    quantidadeDeEspacos++;
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine(frase);
            Console.WriteLine(" ");
            Console.WriteLine("A quantidade de consoantes é: " + quantidadeDeConsoantes);
            Console.WriteLine(" ");
            Console.WriteLine("A quantidade de vogais é: " + quantidadeDeVogais);
            Console.WriteLine(" ");
            Console.WriteLine("A quantidade de espaços é: " + quantidadeDeEspacos);
        }
    }
}
