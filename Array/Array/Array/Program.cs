using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array / Vetor

            int[] numero = new int[5]; //0 até 4 = indices 
            //numero[0] = 5;
            //numero[1] = 7;
            //numero[2] = 9;
            //numero[3] = -8;
            //numero[4] = -78;

            //Console.WriteLine(numero[0]);
            //Console.WriteLine(numero[1]);
            //Console.WriteLine(numero[2]);
            //Console.WriteLine(numero[3]);
            //Console.WriteLine(numero[4]);

            //-----------------------------------------------

            int[] valor = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite um número: ");
                valor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("O quadrado de " + valor[i] + " é: " + Math.Pow(valor[i], 2));
            }
        }
    }
}
