using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_54
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            int numeroAtual = 1;
            int quantidade = 0;

            while (quantidade < 50)
            {
                if (numeroAtual % 2 == 0)
                {
                    resultado = resultado + numeroAtual;
                    quantidade++;
                }
                numeroAtual++;
            }
            Console.WriteLine($"O resultado é {resultado}");

            Console.Read();
        }
    }
}
