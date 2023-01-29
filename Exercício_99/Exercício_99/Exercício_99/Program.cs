using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_99
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];

            for(int i = 0; i < 5; i++)
            {
                Console.Write("Digite um nome: ");
                nome[i] = Console.ReadLine();
            }

            //-------------------------------------------------------> ORDEM INVERSA
            Console.WriteLine(" ");

            Console.WriteLine("Os nomes na ordem inversa ficam: ");

            Console.WriteLine(" ");

            for (int i = 5 - 1 ; i >= 0; i--)
            {
                Console.WriteLine("---> " + nome[i]);
            }
        }
    }
}
