using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_003
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ainda no exercício anterior
            //Imprima a frase digitada pelo usuário sem os espaços em branco.
            //Imprimir também a quantidade de espaços em branco da frase.

            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine().ToUpper();

            Console.WriteLine(" ");

            int quantidadeDeEspacos = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                {
                    Console.Write(frase[i]);
                }
            }

            Console.WriteLine(" ");

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    quantidadeDeEspacos++;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("A quantidade de espaços é: " + quantidadeDeEspacos);
        }
    }
}
