/*
 Exercício 4:
• Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
*/

using System;

namespace Ex._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a;
            
            Console.WriteLine("Vamos descobrir se seu número é impar ou par");

            Console.WriteLine("Digite seu número");

            a = Convert.ToInt32(Console.ReadLine());

             // Usarei um Operador Módulo "%", descobri no google que existe, ele obtém o resto de uma divisão. O que eu farei é simular se a divisão por 2 terá resto ou não. Se não tiver, a=par.
             
            if (a % 2 == 0) 
                
            {
                Console.WriteLine("Seu número é par");

            }
            
            else 
            {
                Console.WriteLine("Seu número é ímpar");

            }
        }
    }
}
