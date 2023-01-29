using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho do Array: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] valor = new int[tamanho]; //New int = quantidade (tamanho)

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Digite um número: ");
                valor[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear(); //muda de página

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("O quadrado de " + valor[i] + " é: " + Math.Pow(valor[i], 2));
            }
        }
    }
}
