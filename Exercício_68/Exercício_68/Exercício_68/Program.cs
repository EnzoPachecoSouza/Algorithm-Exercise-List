using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Se seu sexo for Masculino digite (1), se seu sexo for Femenino digite (0)");

            Console.WriteLine(""); //serve para que já possa ler a linha de baixo automaticamente

            Console.Write("Digite o código do sexo: ");
            double sexo = double.Parse(Console.ReadLine());

            if (sexo < 0 || sexo > 1)
            {
                Console.WriteLine("Não consigo ler esse código, digite (0) para Femenino ou (1) para Maculino.");

            }

            else if (sexo == 0)
            {
                Console.Write("Digite sua altura: ");
                double altura = double.Parse(Console.ReadLine());

                double mulher = (62.1 * altura) - 44.7;

                Console.WriteLine("Seu peso ideal é: " + mulher);
            }

            else if  (sexo == 1)
            {
                Console.Write("Digite sua altura: ");
                double altura = double.Parse(Console.ReadLine());

                double homem = (72.7 * altura) - 58;

                Console.WriteLine("Seu peso ideal é: " + homem);
            }
        }
    }
}
