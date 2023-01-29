using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_46
{
    class Program
    {
        static void Main(string[] args)
        {

            double n1 = 0, n2 = 0, n3 = 0, codigo = 0;
            Console.Write("Escolha o tipo de média que voce deseja fazer: ");
            codigo = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da nota 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da nota 2: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da nota 3: ");
            n3 = double.Parse(Console.ReadLine());

            double medArit = (n1 + n2 + n3) / 3;
            double total1 = (n1 * 3) + (n2 * 3) + (n3 * 4);
            double total2 = 3 + 3 + 4;
            double medPond = total1 / total2;

            if (codigo == 1)
            {
                Console.WriteLine("A média aritmétrica é: " + medArit);
            }

            else if (codigo == 2)
            {
                Console.WriteLine("A média ponderada é: " + medPond);
            }

            Console.Read();
        }
    }
}
