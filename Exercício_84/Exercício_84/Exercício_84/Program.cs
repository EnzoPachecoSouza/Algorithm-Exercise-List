using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_84
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o Limite Superior: ");
            int limiteSuperior = int.Parse(Console.ReadLine());


            for(int i = 1; i < limiteSuperior; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
