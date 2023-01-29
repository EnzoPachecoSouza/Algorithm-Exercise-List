using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0;

            Console.Write("Digite o número da tabuada: ");
            int mult = int.Parse(Console.ReadLine());

            while (n <= 10)
            {
                Console.WriteLine(mult + " x " + n + " = " + mult * n);
                n++;
            }

            Console.Read();
        }
    }
}
