using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_83
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabela de conversão de Polegada para Centímetros");

            Console.WriteLine(" ");

            Console.WriteLine("Polegada -----> Centímetros");

            Console.WriteLine(" ");

            for(int i = 1; i <= 20; i++)
            {
                double conversao = i * 25.4;

                Console.WriteLine(i + " -----> " + conversao);
            }
        }
    }
}
