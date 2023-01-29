using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_44
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1 = 0, p2 = 0, p3 = 0, q1 = 0, q2 = 0, q3 = 0;
            Console.Write("O valor do picolé 1 é: ");
            p1 = double.Parse(Console.ReadLine());
            Console.Write("O valor do picolé 2 é: ");
            p2 = double.Parse(Console.ReadLine());
            Console.Write("O valor do picolé 3 é: ");
            p3 = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor de quantos picolés 1 foram comprados: ");
            q1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de quantos picolés 2 foram comprados: ");
            q2 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de quantos picolés 3 foram comprados: ");
            q3 = double.Parse(Console.ReadLine());

            double totalDeVendas = q1 + q2 + q3;
            double totalDePrecoDosPicoles = p1 + p2 + p3;
            double totalArrecadado = (p1 * q1) + (p2 * q2) + (p3 * q3);

            Console.WriteLine("Foram comprados no total: " + totalDeVendas + " picolés, sendo: " + q1 + " do tipo 1, " + q2 + " do tipo 2, e " + q3 + " do tipo 3");
            Console.WriteLine("O total de arrecadação das vendas foi de: " + totalArrecadado + " reais");

            Console.Read();
        }
    }
}
