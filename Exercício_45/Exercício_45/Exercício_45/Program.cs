using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Produto 1: ");
            string nome1 = Console.ReadLine();
            Console.Write("Produto 2: ");
            string nome2 = Console.ReadLine();
            Console.Write("Produto 3: ");
            string nome3 = Console.ReadLine();
            Console.Write("Produto 4: ");
            string nome4 = Console.ReadLine();
            Console.Write("Produto 5: ");
            string nome5 = Console.ReadLine();

            double valor1 = 0, valor2 = 0, valor3 = 0, valor4 = 0, valor5 = 0, q = 0, codigo = 0;

            Console.Write("Informe o valor do Cachorro Quente: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do Bauru Simples: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do Bauru c/ ovo: ");
            valor3 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do Hambúrguer: ");
            valor4 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do Refrigerante: ");
            valor5 = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de lanche que foi comprado: ");
            q = double.Parse(Console.ReadLine());

            Console.Write("Informe o número do código: ");
            codigo = double.Parse(Console.ReadLine());

            double total1 = valor1 * q;
            double total2 = valor2 * q;
            double total3 = valor3 * q;
            double total4 = valor4 * q;
            double total5 = valor5 * q;

            if (codigo == 100)
            {
                Console.WriteLine("O produto escolhido foi: " + nome1);
                Console.WriteLine("A quantidade de " + nome1 + " escolhido foi: " + q);
                Console.WriteLine("O valor a ser pago por esse lanche é: " + total1);
            }

            else if (codigo == 101)
            {
                Console.WriteLine("O produto escolhido foi: " + nome2);
                Console.WriteLine("A quantidade de " + nome2 + " escolhido foi: " + q);
                Console.WriteLine("O valor a ser pago por esse lanche é: " + total2);
            }

            else if (codigo == 102)
            {
                Console.WriteLine("O produto escolhido foi: " + nome3);
                Console.WriteLine("A quantidade de " + nome3 + " escolhido foi: " + q);
                Console.WriteLine("O valor a ser pago por esse lanche é: " + total3);
            }

            else if (codigo == 103)
            {
                Console.WriteLine("O produto escolhido foi: " + nome4);
                Console.WriteLine("A quantidade de " + nome4 + " escolhido foi: " + q);
                Console.WriteLine("O valor a ser pago por esse lanche é: " + total4);
            }

            else if (codigo == 104)
            {
                Console.WriteLine("O produto escolhido foi: " + nome5);
                Console.WriteLine("A quantidade de " + nome5 + " escolhido foi: " + q);
                Console.WriteLine("O valor a ser pago por esse lanche é: " + total5);
            }

            Console.Read();
        }
    }
}
