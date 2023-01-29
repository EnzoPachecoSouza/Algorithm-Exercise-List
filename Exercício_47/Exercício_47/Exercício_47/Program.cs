using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_47
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int soma = 0;

            while (n <= 100)
            {
                Console.Write(n + "|");

                soma += n; //(+=) mesma coisa  que soma = soma + n
                n++;

                Console.WriteLine(soma);
            }

            //Console.WriteLine(soma); --- Se colocar fora ele mostra lado a lado, se colocar la dentro ele mostra um embaixo do outro ja com a soma de cada um

            Console.Read();
        }       
    }
}
