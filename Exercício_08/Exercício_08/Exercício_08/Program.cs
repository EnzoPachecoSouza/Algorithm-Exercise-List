using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado = 0;
            Console.Write("Informe o valor do lado: ");
            lado = double.Parse(Console.ReadLine());

            double area = lado * 2;
            double per = lado + lado + lado + lado;

            Console.WriteLine("A área do quadrado é: " + area);
            Console.WriteLine("O perímetro do quadrado é: " + per);

            Console.Read();
        }
    }
}
