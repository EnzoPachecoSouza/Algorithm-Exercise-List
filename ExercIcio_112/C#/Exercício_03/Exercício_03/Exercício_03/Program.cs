using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o primeiro nome: ");
            string nome1 = Console.ReadLine();
            Console.Write("Informe o segundo nome: ");
            string nome2 = Console.ReadLine();

            Console.WriteLine("Sequência escrita: " + nome1 + ", " + nome2);
            Console.WriteLine("Sequência inversa: " + nome2 + ", " + nome1);

            Console.Read();
        }
    }
}
