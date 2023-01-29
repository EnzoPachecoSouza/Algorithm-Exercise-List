using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_41
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            Console.Write("Informe o valor de n: ");
            n = double.Parse(Console.ReadLine());

            double raizQ = Math.Sqrt(n);
            double potenciaAoQuadrado = Math.Pow(n, 2);

            if (n > 0)
            {
                Console.WriteLine("O número digitado foi: " + n);
                Console.WriteLine("E sua raiz quadrada é: " + raizQ);
            }
            else if (n < 0)
            {
                Console.WriteLine("O número digitado foi: " + n);
                Console.WriteLine("E sua potência elevada ao quadrado é: " + potenciaAoQuadrado);
            }
            else
            {
                Console.WriteLine("Esse número é nulo");
            }

            Console.Read();
        }
    }
}
