using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_28
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;
            Console.Write("Informe o valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de c: ");
            c = double.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("O número " + a + " é positivo");
            }
            else if (a < 0)
            {
                Console.WriteLine("O número " + a + " é negativo");
            }
            else
            {
                Console.WriteLine("O número " + a + " é nulo");
            }


            if (b > 0)
            {
                Console.WriteLine("O número " + b + " é positivo");
            }
            else if (b < 0)
            {
                Console.WriteLine("O número " + b + " é negativo");
            }
            else
            {
                Console.WriteLine("O número " + b + " é nulo");
            }


            if (c > 0)
            {
                Console.WriteLine("O número " + c + " é positivo");
            }
            else if (c < 0)
            {
                Console.WriteLine("O número " + c + " é negativo");
            }
            else
            {
                Console.WriteLine("O número " + c + " é nulo");
            }


            if (a > b) && (a > c){
                Console.WriteLine(a + " é o maior número");
            }

            else if (b > a) && (b > c){
                Console.WriteLine(b + " é o maior número");
            }

            else{
                Console.WriteLine(c + " é o maior número");
            }

            Console.Read();
        }
    }
}
