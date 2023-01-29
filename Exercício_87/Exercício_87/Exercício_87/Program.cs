using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_87
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for(int i = 25; i <= 200; i++)
            {
               if(i % 2 == 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
