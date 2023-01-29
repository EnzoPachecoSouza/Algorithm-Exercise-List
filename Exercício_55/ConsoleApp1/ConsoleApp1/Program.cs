using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int quantidade = 0;
            int soma = 0;
            int media = 0;
            int maior = 0;
            int menor = 0;
            int mediaPar = 0;

            do
            {
                Console.Write("Digite 1 número: ");
                n = int.Parse(Console.ReadLine());

                if (n != 0)
                {
                    quantidade++;
                    soma += quantidade; // (+=) soma todos os números dentro da quantidade
                    media = (soma / quantidade);
                    
                    if(n % 2 == 0)
                    {
                        mediaPar += quantidade;
                    }
                }

            } while (n != 0);
            double somaPar = (mediaPar / quantidade);

            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Quantidade: " + quantidade);
            Console.WriteLine("Média: " + media);
            Console.WriteLine("Maior: " + maior);
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Média par: " + mediaPar);

            Console.Read();
        }
    }
}
