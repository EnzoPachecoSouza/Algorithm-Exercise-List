using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_33
{
    class Program
    {
        static void Main(string[] args)
        {
            double aE = 0, a = 0;
            Console.Write("Informe o valor da altura do degrau da escada: ");
            aE = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da altura que o usuário deseja alcançar: ");
            a = double.Parse(Console.ReadLine());

            double objetivo = a / aE;

            Console.WriteLine("Para chegar em seu objetivo, o usuário devera subir: " + objetivo + " degraus");

            Console.Read();
        }
    }
}
