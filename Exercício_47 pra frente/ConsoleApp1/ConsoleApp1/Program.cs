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
            //Exercício 47

            //Console.Write("Digite o valor de n1: ");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.Write("Digite o valor de n2: ");
            //int n2 = int.Parse(Console.ReadLine());

            //int soma = 0;

            //while (n1 <= n2)
            //{
            //  soma += n1;
            //n1++;
            //Console.WriteLine(soma);
            //}


            //Exercício 48
            //int leitura = 0;

            //Console.Write("Digite o valor de n: ");
            //int n = int.Parse(Console.ReadLine());

            //if (n > 0)
            //{
            //  Console.WriteLine("Este número é maior que zero!");
            //}

            //else
            //{
            //  Console.WriteLine("Digite um número maior que zero.");
            //}

            //while (leitura <= n)
            //{
            //  Console.WriteLine(leitura);
            //leitura++;
            //}


            //Exercício 49

            //Console.Write("digite o n1: ");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.Write("digite o n2: ");
            //int n2 = int.Parse(Console.ReadLine());

            //while (n1 <= n2)
            //{
            //  Console.WriteLine(n1);
            //n1++;
            //}


            //Exercício 50

            //Console.Write("Digite o  valor de n1: ");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.Write("Digite o  valor de n2: ");
            //int n2 = int.Parse(Console.ReadLine());

            //int soma = 0;

            //while (n1 <= n2)
            //{
            //  soma += n1;
            //n1++;

            //Console.WriteLine(soma); 
            //}


            //Exercício 51

            //Console.Write("Digite o valor de n1: ");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.Write("Digite o valor de n2: ");
            //int n2 = int.Parse(Console.ReadLine());

            //int soma = 0;


            //if (n1 > 0)
            //{
            //  while (n1 <= n2)
            //{
            //  if (n1 % 2 == 0)
            //{
            //  soma = soma + n1;
            //n1++;

            // Console.WriteLine(soma);
            //}

            //else
            //{
            //  n1++;
            //}
            //}
            //}

            // else
            //{
            //  Console.WriteLine("Digite um número maior que zero, pois zero é um número neutro!");
            //}


            //Exercício 52 

            //int n = 0;
            //int menorNumero = int.MaxValue;
            //int maiorNumero = int.MinValue;
            //while (n >= 0)
            //{
            //  Console.Write("Digite um número inteiro, caso queira encerrar, digite um número negativo:  ");
            //n = int.Parse(Console.ReadLine());
            //if (n > 0)
            //{
            //  if (n < menorNumero)
            //{
            //  menorNumero = n;
            //}
            //if (n > maiorNumero)
            //{
            //  maiorNumero = n;
            //}
            //}
            //}

            //Console.WriteLine("Você encerrou o código.");


            //Exercício 53


            //int quantidade = 0;
            //int soma = 0;

            //while (quantidade < 5) 

            //{
            //  Console.Write("Digite um número: ");
            //int n = int.Parse(Console.ReadLine());

            //soma = soma + (n * n);
            //quantidade++;


            //Console.WriteLine(soma); ***SE FOR COLOCADO AQUI DENTRO ELE MOSTRA SOMA POR SOMA 
            //}

            //Console.WriteLine("Já se concluiu os cinco números, e o resultado da soma dos quadrados é: " + soma);



            //Exercício 54

            //Console.Write("Digite um número: ");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.Write("Digite um outro número que, obrigatóriamente tenha diferença de no mínimo 100, por exemplo: se voce digitar 1 como primeiro número, digite 101 como segundo número/ digite: ");
            //int n2 = int.Parse(Console.ReadLine());

            //int quantidade = 0;

            //int soma = 0;

            //if (n1 <= 0 || n2 <= 0)
            //{
            //  Console.WriteLine("Zero é um número neutro, digite um número positivo!");
            //}

            //else
            //{
            //  while (quantidade < 50)
            //{
            //  if (n1 % 2 == 0)
            //{
            //  soma = soma + n1;
            //quantidade++;
            //n1++;

            //Console.WriteLine(soma);
            //}

            //else
            //{
            //  n1++;
            //  }
            //}
            //}


            //Console.WriteLine(soma); 


            //Exercício 56 

            //int numero = 1;

            //int soma3 = 0;

            //int soma5 = 0;

            //while (numero < 1000)
            //{
            //  if (numero % 3 == 0)
            //{
            //  soma3 = soma3 + numero;
            //numero++;
            //}

            //else if (numero % 5 == 0)
            //{
            //  soma5 = soma5 + numero;
            //numero++;
            //}

            //else
            //{
            //  numero++;
            //}
            //}

            //Console.WriteLine(soma3 + soma5);


            //Exercício 57

            //int numero = 1;

            //int somaPar = 0;

            //int somaMult5 = 0;

            //int somaMult7 = 0;

            //while (numero <= 100)
            //{
            //  if (numero % 2 == 0)
            //{
            //  somaPar = somaPar + numero;
            //numero++;
            //}

            //else if (numero % 5 == 0)
            //{
            //  somaMult5 = somaMult5 + numero;
            //numero++;
            //}

            //else if (numero % 7 == 0)
            //{
            //somaMult7 = somaMult7 + numero;
            //  numero++;
            //}

            //else 
            //{
            //  numero++;
            //}
            //} 

            //Console.WriteLine(somaPar + somaMult5 + somaMult7);


            //Exercício 58

            //int numero = 300;

            //while (numero >= 30)
            //{
            //  if (numero % 3 == 0)
            //{
            //  Console.WriteLine(numero);
            //numero--;
            //}

            //else if (numero % 5 == 0)
            //{
            //  Console.WriteLine(numero);
            //numero--;
            //}

            //else
            //{
            //  numero--;
            //}
            //}


            //Exercício 59

            //Console.Write("Digite um número: ");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.Write("Digite um outro número: ");
            //int n2 = int.Parse(Console.ReadLine());
            //if (n1 < n2)
            //{
            //    while (n1 <= n2)
            //    {
            //        if (n1 % 2 == 0 || n1 % 7 == 0)
            //        {
            //            Console.WriteLine(n1);
            //            n1++;
            //        }

            //        else
            //        {
            //            n1++;
            //        }

            //    }
            //}
            //else
            //{
            //    while (n1 >= n2)
            //    {
            //        if (n1 % 2 == 0 || n1 % 7 == 0)
            //        {
            //            Console.WriteLine(n1);
            //            n1--;
            //        }

            //        else
            //        {
            //            n1--;
            //        }
            //    }
            //}


            //Exercício 60

            //int n1 = 1;

            //int n2 = 200;

            //int soma = 0;

            //while (n1 <= n2)
            //{
            //  if (n1 % 2 == 1) //"numero % 2 == 1" 
            //{
            //  soma = soma + n1;
            //n1++;
            //}

            //else
            //{
            //  n1++;
            //}
            //}

            //Console.WriteLine("A soma dos números impares é: " + soma);


            //Exercício 61

            //int n1 = 1000;

            //int n2 = 150;

            //while (n1 >= n2)
            //{
            //  if (n1 % 2 == 1)
            //{
            //  Console.WriteLine(n1);
            //n1--;
            //}

            //else
            ///{
            //   n1--;
            //}
            //}


            //Exercício 62

            //int n1 = 1;
            //int n2 = 20;

            //double conversao = 2.54; //centimetros

            //double resultadoDaConversao = 0;

            //while (n1 <= n2)
            //{
            //  resultadoDaConversao = n1 * conversao;
            //Console.WriteLine(n1 + " polegadas em centimetros é: " + resultadoDaConversao);

            //n1++;
            //}


            //Exercício 63

            //Console.Write("Digite o Limite Superior: ");
            //int limiteSuperior = int.Parse(Console.ReadLine());

            //Console.Write("Digite o Incremento: ");
            //int incremento = int.Parse(Console.ReadLine());

            //int inicial = 0;


            //if (incremento > 0 && limiteSuperior > 0 && limiteSuperior % incremento == 0)
            //{
            //  while (inicial <= limiteSuperior)
            //{
            //  if (inicial % incremento == 0)
            //{
            //  Console.WriteLine(inicial);
            //inicial++;
            //}

            //else
            //{
            //  inicial ++;
            //}
            //}
            //}

            //else
            //{
            //  Console.WriteLine("O incremento e o limite superior devem ser maior que zero, e o limite superior tem que ser multiplo do incremento!");
            //}


            //Exercício 64

            //Console.Write("Digite um número: ");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.Write("Digite um outro número: ");
            //int n2 = int.Parse(Console.ReadLine());

            //if (n1 > 0 && n2 > 0 && n1 <= 100 && n2 <= 100)
            //{
            //  if (n1 < n2)
            //{
            //  Console.WriteLine("O menor número é: " + n1);
            //}

            //else
            //{
            //  Console.WriteLine("O menor número é: " + n2);
            //}
            //}

            //else
            //{
            //  Console.WriteLine("Os dois números tem que ser maior que zero e menor ou igual a cem");
            //}


            //Exercício 65

            //Console.Write("Qual o nível de alerta? ");
            //int nivelDeAlerta = int.Parse(Console.ReadLine());

            //if (nivelDeAlerta > 9)
            //{
            //  Console.WriteLine("O nivel de alerta é GRAVE!!!");
            //}

            //else
            //{
            //  Console.WriteLine("O nivel de alerta é não é grave");
            //}


            //Exercício 67 

            //Console.Write("Digite um número: ");
            //int numero = int.Parse(Console.ReadLine());

            //if (numero % 2 == 0)
            //{
            //  int somaPar = numero + 5;

            //Console.WriteLine("A soma de " + numero + " + 5, é: " + somaPar);
            //}

            //else
            //{
            //  int somaImpar = numero + 8;

            //  Console.WriteLine("A soma de " + numero + " + 8, é: " + somaImpar);
            //}



            //Exercício 69 

            //int numero1 = 1;

            //int numero2 = 100;

            //while (numero1 <= numero2)
            //{
            //  if (numero1 % 2 == 0)
            //{
            //  Console.WriteLine(numero1 + " #");
            //numero1++;
            //}

            //else
            //{
            //  Console.WriteLine(numero1 + " *");
            //numero1++;
            //}
            //}


            //Exercício 70

            //int n1 = 1;

            //int n2 = 100;

            //while (n1 <= n2)
            //{
            //  if (n1 % 4 == 0)
            //{
            //  Console.WriteLine("PI");
            //n1++;
            //}

            //else
            //{
            //  Console.WriteLine(n1);
            //n1++;
            //}
            //}


            //Exercício 71

            //double quantidade = 1;

            //while (quantidade <= 10)
            //{
              //  Console.Write("Digite um número: ");
                //double numero = double.Parse(Console.ReadLine());

                //double metade = numero / 2;
                //Console.WriteLine("o número é "+ numero + " e sua metade é: " + metade);

                //quantidade++;
            //}
        }
    }
}