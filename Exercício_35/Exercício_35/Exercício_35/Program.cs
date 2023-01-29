using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_35
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 0, D = 0;
            Console.Write("Informe o valor da diagonal menor: ");
            d = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da diagonal maior: ");
            D = double.Parse(Console.ReadLine());

            double area = (d * D) / 2;
            double lado = area / 2;

            if (d <= 0 || D <= 0)
            {
                Console.WriteLine("Valores Inválido");
            }

            else
            {
                Console.WriteLine("O valor do lado do losango é: " + lado);
            }

            Console.Read();
        }
    }
}
