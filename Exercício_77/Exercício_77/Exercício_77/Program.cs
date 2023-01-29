using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_77
{
    class Program
    {
        static void Main(string[] args)
        {
            for(double i = 1; i <= 20; i++)
            {
                double quadrado = Math.Pow(i, 2);

                Console.WriteLine("O quadrado do número " + i + " é: " + quadrado);
            }
        }
    }
}
