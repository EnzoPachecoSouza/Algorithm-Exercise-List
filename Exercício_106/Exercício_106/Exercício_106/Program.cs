using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_106
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine(" ");

            for(int i = nome.Length - 1; i >= 0; i--)
            {
                Console.Write(nome[i]);
            }

            Console.WriteLine(" ");
        }
    }
}
