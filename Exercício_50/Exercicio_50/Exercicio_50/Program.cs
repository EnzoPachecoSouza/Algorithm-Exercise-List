using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int soma = 0;

            while (n1 < n2)
            {
                soma = soma + n1;
                n1++;
            }

            Console.WriteLine($"O resultado é {soma}");

            Console.Read();
        }
    }
}
