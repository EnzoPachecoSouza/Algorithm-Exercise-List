using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_91
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idade = new int[20];

            string[] nome = new string[20];

            for(int i = 0; i < 20; i++)
            {
                Console.Write("Digite o seu nome: ");
                nome[i] = Console.ReadLine();

                Console.Write("Digite sua idade: ");
                idade[i] = int.Parse(Console.ReadLine());

                Console.WriteLine(" ");
            }

            Console.Clear();

            for(int i = 0; i < 20; i++)
            {
                if(idade[i] >= 18 && idade[i] <= 20)
                {
                    Console.WriteLine("A canditada " + nome[i] + " que possui " + idade[i] + " anos, está apta para o concurso!");

                    Console.WriteLine(" ");
                }

                else
                {
                    Console.WriteLine("A canditada " + nome[i] + " que possui " + idade[i] + " anos, não está apta para o concurso!");

                    Console.WriteLine(" ");
                }
            }
        }
    }
}
