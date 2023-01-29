using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_09
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 0, h = 0;
            Console.Write("Informe o valor de b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de h: ");
            h = double.Parse(Console.ReadLine());

            double area = b * h;
            double per = (b * 2) + (h * 2);

            Console.WriteLine("A área do retangulo é: " + area);
            Console.WriteLine("O perímetro do retangulo é: " + per);

            Console.Read();
        }
    }
}
