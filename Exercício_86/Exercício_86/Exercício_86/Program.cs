﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_86
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int soma = 0;

            for(int i = 1; i <= numero; i++)
            {
                Console.WriteLine(i);

                soma += i;
            }

            Console.WriteLine(" ");

            Console.WriteLine("O seu produto é: " + soma);
        }
    }
}
