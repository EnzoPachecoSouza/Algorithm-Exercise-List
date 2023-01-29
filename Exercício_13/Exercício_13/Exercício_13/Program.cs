using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_13
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

            double total1 = (n1 * 1) + (n2 * 2) + (n3 * 3) + (n4 * 4);
            double total2 =  1 + 2 + 3 + 4;
            double media = total1 / total2;

            Console.WriteLine("Informe a média ponderada: " + media);

            Console.Read();

        }
    }
}
