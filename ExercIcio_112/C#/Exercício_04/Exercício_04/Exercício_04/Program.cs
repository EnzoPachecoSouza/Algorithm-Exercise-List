using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.Write("Informe o valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de b: ");
            b = int.Parse(Console.ReadLine());

            int acres = (a + 1);
            int decres = (b - 1);

            Console.WriteLine("O valor acrescido de a é: " + acres);
            Console.WriteLine("O valor decrescido de b é: " + decres);

            Console.Read();
        }
    }
}
