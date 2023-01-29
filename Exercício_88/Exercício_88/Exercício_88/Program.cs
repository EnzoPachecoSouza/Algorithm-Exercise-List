using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_88
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aux = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número maior do que zero: ");
                int numero = int.Parse(Console.ReadLine());

                if(numero > 0)
                {
                    aux[i] = numero;
                }
                 
                else
                {
                    do
                    {
                        Console.WriteLine("Você digitou um valor errado!!!");

                        Console.WriteLine(" ");

                        Console.Write("Digite um número maior do que zero: ");
                        numero = int.Parse(Console.ReadLine());
                        aux[i] = numero;

                    }while (numero <= 0);
                }
            }

            Console.Clear(); 

            for (int i = 0; i < 10; i++)
            {
                if (aux[i] % 2 == 0)
                {
                    Console.WriteLine(aux[i] + " É PAR");
                }

                else
                {
                    Console.WriteLine(aux[i] + " É IMPAR");
                }
            }
        }
    }
}
