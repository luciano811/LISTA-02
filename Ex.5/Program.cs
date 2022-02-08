/*
 
 Exercício 5:
• Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B.
Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

*/


using System;

namespace Ex._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Calculadora malucuca: lê dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B");
            
            Console.WriteLine();

            int A;
            int B;
            int C;



            Console.WriteLine("Digite o primeiro numero inteiro A");

                A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero inteiro B");

                B = Convert.ToInt32(Console.ReadLine());


            if (A == B)
            {
                Console.Write("C é igual a ");
                C = A + B;
                Console.WriteLine(C);    

            }

            else
            {
                Console.Write("C é igual a ");
                C = A * B;
                Console.WriteLine(C);    
            }

        }
    }
}
