using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_52 
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int menorNumero = int.MaxValue;
            int maiorNumero = int.MinValue;

            while (n >= 0)
            {
                Console.Write("Digite um número inteiro, caso queira encerrar, digite um número negativo:  ");
                n = int.Parse(Console.ReadLine());

                if (n > 0)
                {
                    if (n < menorNumero)
                    {
                        menorNumero = n;
                    }

                    if (n > maiorNumero)
                    {
                        maiorNumero = n;
                    }
                }
            }

            Console.WriteLine("Você encerrou o código.");

            Console.WriteLine(" ");

            Console.WriteLine("O menor número é: " + menorNumero);
            Console.WriteLine("O maior número é: " + maiorNumero);

        }
    }
}
