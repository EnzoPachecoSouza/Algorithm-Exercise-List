using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_37
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            Console.Write("Informe o valor do número: ");
            n = double.Parse(Console.ReadLine());

            double quadrado = Math.Pow(n, 2);
            double raizCubica = Math.Pow(n, 1.0/3.0);

            if (quadrado > 10)
            {
                Console.WriteLine("A raiz quadrada de " + n + " é: " + quadrado);
                Console.WriteLine(quadrado + " é maior que 10!");
                Console.WriteLine("E sua raiz cúbica é: " + raizCubica);
            }
            else if (quadrado < 10)
            {
                Console.WriteLine("A raiz quadrada de " + n + " é: " + quadrado);
                Console.WriteLine(quadrado + " é menor que 10!");
            }
            else
            {
                Console.WriteLine("A raiz quadrada de " + n + " é: " + quadrado);
                Console.WriteLine(quadrado + " é igual a 10!");
            }

            Console.Read();
        }
    }
}
