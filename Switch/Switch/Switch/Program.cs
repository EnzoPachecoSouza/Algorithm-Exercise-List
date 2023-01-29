using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            //if (numero == 1)
            //{
            //    Console.WriteLine("Um");
            //}
            //else
            //{
            //    if (numero == 2)
            //    {
            //        Console.WriteLine("");
            //    }
            //    else
            //    {
            //        if ()
            //    }
            //}
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                default:
                    Console.WriteLine("Não sei que número é esse!");
                    break;

            }
            Console.Read();
        }
    }
}
