using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0;
            Console.Write("Informe o valor do raio: ");
            r = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(r, 2);
            double per = 2 * Math.PI * r;

            Console.WriteLine("A área do círculo é: " + area);
            Console.WriteLine("O perímetro do círculo é: " + per);

            Console.Read();
        }
    }
}
