using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_107
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string: ");
            string strg = Console.ReadLine().ToUpper(); //ToUpper Maisculo

            for(int i = 0; i < strg.Length; i++)
            {
                if (strg[i] != 'A' && strg[i] != 'E' && strg[i] != 'I' && strg[i] != 'O' && strg[i] != 'U')
                {
                    Console.Write(strg[i]);
                }
            }
        }
    }
}
