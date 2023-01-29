using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_25
{
    class Program
    {
        static void Main(string[] args)
        {
            double ctt1 = 0, ctt2 = 0;
            Console.Write("Informe o valor do cateto 1: ");
            ctt1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do cateto 2: ");
            ctt2 = double.Parse(Console.ReadLine());

            double area = (ctt1 * ctt2) / 2;
            double hip = Math.Sqrt(Math.Pow(ctt1, 2) + Math.Pow(ctt2, 2));

            Console.WriteLine("A área é: " + area);
            Console.WriteLine("A hipotenusa é: " + hip);

            Console.Read();
        }
    }
}
