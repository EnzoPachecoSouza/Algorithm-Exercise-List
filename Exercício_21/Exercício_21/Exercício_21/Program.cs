using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_21
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0, n3 = 0, n4 = 0;
            Console.Write("Informe o valor de n1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de n2: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de n3: ");
            n3 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de n4: ");
            n4 = double.Parse(Console.ReadLine());

            double total1 = (n1 * 3) + (n2 * 5) + (n3 * 6) + (n4 * 6);
            double total2 = 3 + 5 + 6 + 6;
            double media = total1 / total2;

            Console.WriteLine("A média Pondera é: " + media);
            Console.WriteLine((media >= 6.00) ? "Aprovado" : "Reprovado");

            Console.Read();
        }
    }
}
