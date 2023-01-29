using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.Write("Informe o valor de a: ");
            a = int.Parse(Console.ReadLine());

            int ant = a - 1;
            int suc = a + 1;

            Console.WriteLine("O número digitado foi: " + a);
            Console.WriteLine("O seu antecessor é: " + ant);
            Console.WriteLine("O seu sucessor é: " + suc);

            Console.Read();
        }
    }
}
