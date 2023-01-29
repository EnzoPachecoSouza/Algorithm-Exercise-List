using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_43
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso = 0, altura = 0;
            Console.Write("Informe o seu peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Informe a sua altura: ");
            altura = double.Parse(Console.ReadLine());

            double alturaElevada = Math.Pow(altura, 2);
            //IMC = Índice de Massa Corporal
            double imc = peso / alturaElevada;

            Console.WriteLine("Seu IMC é: " + imc);

            if (peso <= 0 || altura <= 0)
            {
                Console.WriteLine("Valor Inválido");
            }
            
            else if (imc < 17)
            {
                Console.WriteLine("Você está muito abaixo do peso");
            }

            else if (imc > 17 && imc < 18.49)
            {
                Console.WriteLine("Você está abaixo do peso");
            }

            else if (imc > 18.50 && imc < 24.99)
            {
                Console.WriteLine("Você está com o peso normal");
            }

            else if (imc > 25 && imc < 29.99)
            {
                Console.WriteLine("Você está acima do peso");
            }

            else if (imc > 30 && imc < 34.99)
            {
                Console.WriteLine("Você está em estado de obesidade I");
            }

            else if (imc > 35 && imc < 39.99)
            {
                Console.WriteLine("Você está em caso de obesidade II (severa)");
            }

            else if (imc > 40)
            {
                Console.WriteLine("Você está em caso de obesidade III (mórbida)");
            }

            Console.Read();
        }
    }
}
