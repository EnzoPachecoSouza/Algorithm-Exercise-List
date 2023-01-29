using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            Console.Write("Informe o valor de a: ");
            a = double.Parse(Console.ReadLine());

            double raizq = Math.Sqrt(a);

            Console.WriteLine("A raiz quadrada do número " + a + " é: " + raizq);

            Console.Read();
        }
    }
}
