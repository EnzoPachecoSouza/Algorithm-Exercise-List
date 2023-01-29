using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_24
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0, quilowatts = 0;
            Console.Write("Informe o valor do salário: ");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor do quilowatts: ");
            quilowatts = Convert.ToDouble(Console.ReadLine());

            double precoDoQuilowatt = (salario / 7) / 100; //para achar 1 quilowatts
            double valorEmReaisASerPago = precoDoQuilowatt * quilowatts;
            double desconto = valorEmReaisASerPago * 0.1;
            double novoValor = valorEmReaisASerPago - desconto;

            Console.WriteLine("O valor de um quilowatt é: " + precoDoQuilowatt);
            Console.WriteLine("O valor em Reais a ser pago é: " + valorEmReaisASerPago);
            Console.WriteLine("Nobo valor a ser pago com desconto de 10% " + novoValor);

            Console.Read();

        }
    }
}
