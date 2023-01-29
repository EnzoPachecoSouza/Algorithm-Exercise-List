using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            Console.Write("Informe o valor de a: ");
            a = double.Parse(Console.ReadLine());

            double raizc = Math.Pow(a, 1.0 / 3.0);
            double raizq = Math.Sqrt(a);

            Console.WriteLine("O número digitado foi: " + a);
            Console.WriteLine("E sua raiz cubica é: " + raizc);
            Console.WriteLine("E sua raiz quadrada é: " + raizq);

            Console.Read();
        }
    }
}
