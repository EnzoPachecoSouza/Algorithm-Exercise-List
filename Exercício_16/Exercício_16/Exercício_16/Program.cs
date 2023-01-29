using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 0, B = 0, h = 0;
            Console.Write("Informe o valor da base menor do trapézio: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da base maior do trapézio: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da altura do trapézio: ");
            h = double.Parse(Console.ReadLine());

            double area = ((B + b) * h) / 2;

            Console.WriteLine("Informe o valor da área: " + area);

            Console.Read();
        }
    }
}
