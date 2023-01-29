using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0;
            Console.Write("Informe o valor do raio da esfera: ");
            r = double.Parse(Console.ReadLine());

            double area = 4 * Math.PI * Math.Pow(r, 2);
            double vol = (4 / 3) * Math.PI * Math.Pow(r, 3);

            Console.WriteLine("A área da esfera é: " + area);
            Console.WriteLine("O volume da esfera é: " + vol);

            Console.Read();
        }
    }
}
