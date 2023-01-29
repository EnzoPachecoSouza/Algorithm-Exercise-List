using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                double resultado = Math.Pow(numero, 4);
                if ((resultado % 2 == 0) && (resultado % 5 == 0))
                {
                    // Par
                    Console.WriteLine("O número digitado foi " + numero);
                    Console.WriteLine("Seu valor elevado ao quadrado é " + Math.Pow(numero, 2));
                    Console.WriteLine("Seu valor elevado ao cubo é " + Math.Pow(numero, 3));
                    Console.WriteLine("Seu valor elevado a sétima é " + Math.Pow(numero, 7));
                }
                else
                {
                    // Ímpar
                    Console.WriteLine("O número digitado foi " + numero);
                    Console.WriteLine("Sua raiz quadrada é " + Math.Sqrt(numero));
                    Console.WriteLine("Sua raiz cúbica é " + Math.Pow(numero, 1.0 / 3.0));
                    Console.WriteLine("Sua raiz a sétima é " + Math.Pow(numero, 1.0 / 7.0));
                }
            }
            else
            {
                Console.WriteLine("Número inválido!");
            }
            Console.ReadKey();
        }
    }
}
