using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            Console.Write("Informe o valor de a: ");
            a = double.Parse(Console.ReadLine());

            double pot2 = Math.Pow(a, 2);
            double pot3 = Math.Pow(a, 3);
            double pot4 = Math.Pow(a, 4);
            double pot5 = Math.Pow(a, 5);

            Console.WriteLine("O número digitado foi: " + a);
            Console.WriteLine("E seu valor elevado a 2 é: " + pot2);
            Console.WriteLine("E seu valor elevado a 3 é: " + pot3);
            Console.WriteLine("E seu valor elevado a 4 é: " + pot4);
            Console.WriteLine("E seu valor elevado a 5 é: " + pot5);

            Console.Read();
        }
    }
}
