using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite o n1: ");
            int n1 = int.Parse(Console.ReadLine());
            n1++;

            Console.Write("digite o n2: ");
            int n2 = int.Parse(Console.ReadLine());
            n2--;

            //Para mosntrar os nºs que estão entre dois números, só colocar n1++ em um, e n2-- no outro, assim, na hora de monstrar ele mostrar apenas os números compreendidos

            while (n1 <= n2)
            {
              Console.WriteLine(n1);
                n1++;
            }
        }
    }
}
