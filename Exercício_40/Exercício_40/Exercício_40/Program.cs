using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação você deseja fazer?");
            Console.WriteLine("Digite 1 se a operação for soma");
            Console.WriteLine("Digite 2 se a operação for subtração");
            Console.WriteLine("Digite 3 se a operação for divisão");
            Console.WriteLine("Digite 4 se a operação for multiplicação");

            Console.WriteLine("");

            double op = 0;
            Console.Write("A sua escolha é: ");
            op = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double n1 = 0, n2 = 0;
            Console.Write("Informe o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double soma = n1 + n2;
            double sub = n1 - n2;
            double div = n1 / n2;
            double mult = n1 * n2;

            Console.WriteLine("");

            if (op == 1)
            {
                Console.WriteLine("O resultado da soma é: " + soma);
            }

            else if (op == 2)
            {
                Console.WriteLine("O resultado da subtração é: " + sub);
            }

            else if (op == 3)
            {
                Console.WriteLine("O resultado da divisão é: " + div);
            }

            else if (op == 4)
            {
                Console.WriteLine("O resultado da multiplicação é: " + mult);
            }

            else
            {
                Console.WriteLine("Esse número é invalido");
            }

            Console.Read();
        }
    }
}
