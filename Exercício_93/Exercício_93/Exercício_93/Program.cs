using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_93
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de alunos: ");
            int numeroDeAlunos = int.Parse(Console.ReadLine());

            Console.Write("Informe quantas notas serão usadas: ");
            int quantidadeDeNotas = int.Parse(Console.ReadLine());

            Console.Clear();

            int[] nota = new int[quantidadeDeNotas];

            double soma = 0;

            double media = 0;

            int maioresDoQue7 = 0;

            int menoresDoQue5 = 0;


            for(int i = 0; i < numeroDeAlunos; i++)
            {
                int aux2 = i + 1;

                for (int j = 0; j < quantidadeDeNotas; j++)
                {
                    int aux = j + 1;

                    Console.Write(aux + "º nota do aluno " + aux2 + " : ");
                    nota[j] = int.Parse(Console.ReadLine());

                    soma = soma + nota[j];
                    media = soma / quantidadeDeNotas;
                }

                Console.WriteLine("A média do aluno " + aux2 + " é: " + media);

                Console.WriteLine(" ");

                if(media > 7)
                {
                    maioresDoQue7++;
                }

                else if(media < 5)
                {
                    menoresDoQue5++;
                }

                soma = 0;
            }

            if(menoresDoQue5 == numeroDeAlunos)
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5.0!");
            }

            Console.WriteLine("A quantidade de números com a média maior do que 7.0 é: " + maioresDoQue7);
        }
    }
}
