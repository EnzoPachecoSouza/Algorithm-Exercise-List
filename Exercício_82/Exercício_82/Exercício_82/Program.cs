using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_82
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Digite um " + i + "º número: ");
                double numero = double.Parse(Console.ReadLine());

                double cubo = Math.Pow(numero, 3);
                double raizCubica = Math.Pow(numero, 1.0 / 3.0);

                Console.WriteLine("O cubo do número " + numero + " é: " + cubo + " , e suas raiz cúbica é: " + raizCubica);

                Console.WriteLine(" ");
            }
        }
    }
}
