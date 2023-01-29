using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_90
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tamanho = new int[10];

            int numerosMaioresQueX = 0;
            int numerosMenoresQueX = 0;
            int numerosIguaisAX = 0;

            for (int i = 0; i < tamanho.Length; i++)
            {
                int aux = i + 1; //Número Ordinal

                Console.Write("Digite o " + aux + "º número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    tamanho[i] = numero;
                }

                else
                {
                    do
                    {
                        Console.Write("NÚMERO INVÁLIDO, O NÚMERO DEVE SER INTEIRO E MAIOR DO QUE ZERO!!!");
                        Console.WriteLine(" ");

                        Console.Write("Digite o " + aux + "º número: ");
                        int n1 = int.Parse(Console.ReadLine());


                        if (n1 > 0)
                        {
                            tamanho[i] = n1;
                        }

                        numero = n1;

                    } while (numero <= 0);
                }
            }

            Console.Clear();

            Console.Write("Digite um número para variável X: ");
            int X = int.Parse(Console.ReadLine());

            for(int i = 0; i < tamanho.Length; i++)
            {
                if(tamanho[i] > X)
                {
                    numerosMaioresQueX++;
                }

                else if (tamanho[i] < X)
                {
                    numerosMenoresQueX++;
                }

                else
                {
                    numerosIguaisAX++;
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Os números maiores que X são: " + numerosMaioresQueX);
            Console.WriteLine(" ");
            Console.WriteLine("Os números menores que X são: " + numerosMenoresQueX);
            Console.WriteLine(" ");
            Console.WriteLine("Os números iguais a X são: " + numerosIguaisAX);
        }
    }
}
