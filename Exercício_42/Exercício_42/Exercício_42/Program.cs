using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome do aluno: ");
            string nome = Console.ReadLine();

            double n1 = 0, n2 = 0;
            Console.Write("Informe a primeira nota do " + nome + ": ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Informe a segunda nota do " + nome + ": ");
            n2 = double.Parse(Console.ReadLine());
            
            double media = (n1 + n2) / 2;

            if (n1 > 10 || n2 > 10 || n1 < 0 || n2 < 0)
            {
                Console.WriteLine("Esse número é inválido");
            }

            else if (media > 7)
            {
                Console.WriteLine("Aprovado");
            }

            else if (media < 5)
            {
                Console.WriteLine("Retido");
            }

            else if (media == 6)
            {
                Console.WriteLine("Recuperação");
            }

            Console.Read();
        }
    }
}
