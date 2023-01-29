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
            Console.WriteLine("---> Enzo Pacheco de Oliveira Souza");
            Console.WriteLine("---> F2211490");
            Console.WriteLine("---> Exercício 02 e Exercício 03");
            Console.WriteLine("  ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  ");

            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            int quantidadeDeVogais = 0;

            int quantidadeDea = 0;

            int quantidadeDee = 0;

            int quantidadeDei = 0;

            int quantidadeDeo = 0;

            int quantidadeDeu = 0;

            Console.WriteLine("  ");

            //-------------------------------------------------> QUANTIDADE DE VOGAIS
            for (int i = 0; i < frase.Length; i++)
            {
                if(frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
                {
                    quantidadeDeVogais++;
                }

                else if(frase[i] == 'A' || frase[i] == 'E' || frase[i] == 'I' || frase[i] == 'O' || frase[i] == 'U')
                {
                    quantidadeDeVogais++;
                }
            }

            Console.WriteLine("A quantida de vogais na frase é: " + quantidadeDeVogais);

            Console.WriteLine(" ");

            //-------------------------------------------------> QUANTIDADE DE VOGAIS SEPARADAS
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'a' || frase[i] == 'A')
                {
                    quantidadeDea++;
                }

                else if (frase[i] == 'e' || frase[i] == 'E')
                {
                    quantidadeDee++;
                }

                else if (frase[i] == 'i' || frase[i] == 'I')
                {
                    quantidadeDei++;
                }

                else if (frase[i] == 'o' || frase[i] == 'O')
                {
                    quantidadeDeo++;
                }

                else if (frase[i] == 'u' || frase[i] == 'U')
                {
                    quantidadeDeu++;
                }
            }

            Console.WriteLine("A quantida de vogal (A) na frase é: " + quantidadeDea);
            Console.WriteLine("A quantida de vogal (E) na frase é: " + quantidadeDee);
            Console.WriteLine("A quantida de vogal (I) na frase é: " + quantidadeDei);
            Console.WriteLine("A quantida de vogal (O) na frase é: " + quantidadeDeo);
            Console.WriteLine("A quantida de vogal (U) na frase é: " + quantidadeDeu);

            Console.WriteLine(" ");

            //-------------------------------------------------> IMPRIMIR SEM ESPAÇO
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                {
                    Console.Write(frase[i]);
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //-------------------------------------------------> ENTRADA DE VOGAL OU CONSOANTE

            Console.Write("Entre com uma vogal ou consoante: ");
            string vogalOuConsoante = Console.ReadLine();

            char entrada = char.Parse(vogalOuConsoante);

            Console.WriteLine(" ");

            Console.WriteLine("A frase original é: " + frase);

            Console.WriteLine(" ");

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'a' || frase[i] == 'A' || frase[i] == 'e' || frase[i] == 'E' || frase[i] == 'i' || frase[i] == 'I' || frase[i] == 'o' || frase[i] == 'O' || frase[i] == 'u' || frase[i] == 'U')
                {
                    Console.Write(entrada);
                }

                else
                {
                    Console.Write(frase[i]);
                }
            }

            Console.WriteLine(" ");
        }
    }
}
