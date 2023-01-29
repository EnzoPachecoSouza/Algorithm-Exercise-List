using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_34
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 0, D = 0;
            Console.Write("Informe o valor de d: ");
            d = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de D: ");
            D = double.Parse(Console.ReadLine());

            double area = (d * D) / 2;

           if (d <= 0 || D <= 0)
            { 
                Console.WriteLine("Valores Inválidos");
            }

            else
            {
                Console.WriteLine("A área do Losango é: " + area);
            }

            Console.Read(); 
        }

    }
}
