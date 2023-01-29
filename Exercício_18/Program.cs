using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_18
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0, R = 0;
            Console.Write("Informe o valor de r: ");
            r = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de R: ");
            R = double.Parse(Console.ReadLine());

            double areaM = Math.PI * Math.Pow(R, 2);
            double area = (Math.PI * Math.Pow(R, 2)) - (Math.PI * Math.Pow(r, 2));

            Console.WriteLine("A area da circunferencia é: " + areaM);
            Console.WriteLine("A area é: " + area);

            Console.Read();
        }
    }
}
