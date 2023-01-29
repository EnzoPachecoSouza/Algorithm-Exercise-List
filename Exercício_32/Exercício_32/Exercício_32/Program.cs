using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_32
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            Console.Write("Informe o valor do salário: ");
            s = double.Parse(Console.ReadLine());

            double porcentagem = s * 0.25;
            double sAtual = s + porcentagem;

            Console.WriteLine("O salário atual do funcionário, com aumento de 25% é: " + sAtual);

            Console.Read();
        }
    }
}
