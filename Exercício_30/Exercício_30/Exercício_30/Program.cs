using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_30
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = 0;
            Console.Write("Informe a temperatura em Cº: ");
            C = double.Parse(Console.ReadLine());

            double F = (C * (9.0 / 5.0)) + 32.0;

            Console.WriteLine("A temperatudo de " + C + " graus Celcius convertida para Fahrenheit, é de: " + F + " Fahrenheit");

            Console.Read();
        }
    }
}
