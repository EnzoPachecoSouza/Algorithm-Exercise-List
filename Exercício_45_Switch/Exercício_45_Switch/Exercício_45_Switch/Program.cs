using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_45_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            double codigo = 0, quantidade = 0;

            Console.Write("Informe o código: ");
            codigo = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade: ");
            quantidade = double.Parse(Console.ReadLine());

            double c100 = 4.50;
            double c101 = 4.50;
            double c102 = 5.50;
            double c103 = 6.50;
            double c104 = 3.50;

            switch (codigo)
            {
                case 100:
                    Console.WriteLine("Cachorro Quente");
                    Console.WriteLine("O valor unitário desse produto é: 4,50");
                    double valorTotal100 = c100 * quantidade;
                    Console.WriteLine("O valor a ser pago por esse item é: " + valorTotal100 + " reais");
                break;

                case 101:
                    Console.WriteLine("Bauru Simples");
                    Console.WriteLine("O valor unitário desse produto é: 4,50");
                    double valorTotal101 = c101 * quantidade;
                    Console.WriteLine("O valor a ser pago por esse item é: " + valorTotal101 + " reais");
                break;

                case 102:
                    Console.WriteLine("Bauru com ovo");
                    Console.WriteLine("O valor unitário desse produto é: 5,50");
                    double valorTotal102 = c102 * quantidade;
                    Console.WriteLine("O valor a ser pago por esse item é: " + valorTotal102 + " reais");
                break;

                case 103:
                    Console.WriteLine("Hambúrguer");
                    Console.WriteLine("O valor unitário desse produto é: 6,50");
                    double valorTotal103 = c103 * quantidade;
                    Console.WriteLine("O valor a ser pago por esse item é: " + valorTotal103 + " reais");
                break;

                case 104:
                    Console.WriteLine("Hambúrguer");
                    Console.WriteLine("O valor unitário desse produto é: 6,50");
                    double valorTotal104 = c104 * quantidade;
                    Console.WriteLine("O valor a ser pago por esse item é: " + valorTotal104 + " reais");
                break;
            }
            Console.Read();
        }
    }
}
