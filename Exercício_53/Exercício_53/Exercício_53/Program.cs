using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_53
{
    class Program
    {
        static void Main(string[] args)
        {


            int numero = 0;
            int quantidade = 0;

            while (quantidade < 5)
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"O quadrado de {numero} é {numero * numero}");
                quantidade++;
            }

            Console.Read();
        }
    }
}
