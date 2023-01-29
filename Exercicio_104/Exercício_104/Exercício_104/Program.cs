using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_104
{
    class Program
    {
        static void Main(string[] args)
        {
            //String já é um vetor

            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();

            for(int i = 0; i < nome.Length; i++)
            {
                Console.Write(nome[i]);

                if(i < nome.Length - 1) //Para deixar o traço de acordo com o nome, e não sobrar
                {
                    Console.Write("-");
                }
            }

            Console.WriteLine(" ");
        }
    }
}
