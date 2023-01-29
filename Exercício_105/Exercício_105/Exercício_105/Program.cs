using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_105
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();

            int quantidadeDeLetra = 0;

            for(int i = 0; i < nome.Length; i++)
            {
                quantidadeDeLetra = nome.Length;
            }

            Console.WriteLine("A quantidade de letras é: " + quantidadeDeLetra);
        }
    }
}
