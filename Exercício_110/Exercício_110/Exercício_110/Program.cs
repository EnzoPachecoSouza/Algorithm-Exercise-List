using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_110
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            for(int i = 0; i < frase.Length; i++)
            {
                if(frase[i] == 'A' || frase[i] == 'a' || frase[i] == 'E' || frase[i] == 'e' || frase[i] == 'I' || frase[i] == 'i' || frase[i] == 'O' || frase[i] == 'o' || frase[i] == 'U' || frase[i] == 'u')
                {
                    Console.Write(frase[i]);
                }
            }
        }
    }
}
