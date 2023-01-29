using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0, n3 = 0;
            Console.Write("Informe o valor de n1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de n2: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de n3: ");
            n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            Console.WriteLine("A média aritimétrica é: " + media);
            Console.WriteLine((media >= 7.50) ? "Aprovado" : "Reprovado");

            Console.Read();
        }
    }
}
