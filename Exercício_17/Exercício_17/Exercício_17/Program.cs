using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0, h = 0;
            Console.Write("Informe o valor do raio do prisma: ");
            r = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da altura do prisma: ");
            h = double.Parse(Console.ReadLine());

            double areab = Math.PI * Math.Pow(r, 2);
            double vol = (Math.PI * Math.Pow(r, 2)) * h;

            Console.WriteLine("Informe o valor do volume do prisma: " + vol);

            Console.Read();
        }
    }
}
