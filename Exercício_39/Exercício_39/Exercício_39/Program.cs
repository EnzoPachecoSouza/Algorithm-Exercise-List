using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_39
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            Console.Write("Informe o valor do salário: ");
            salario = double.Parse(Console.ReadLine());

            double aumento = salario * 0.25;
            double novoSalario = salario + aumento;

            Console.WriteLine("O valor do novo salário do funcionário, com aumento de 25% é: " + novoSalario);

            Console.Read();
        }
    }
}
