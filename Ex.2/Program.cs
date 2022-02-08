using System;


// Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.


namespace Ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            
            Console.WriteLine("Bem-vindo ao algoritmo, Digite os valores inteiros (e difrentes)");
           
            Console.WriteLine("Digite o valor A");

            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor B");

            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor C");

            c = Convert.ToInt32(Console.ReadLine());

            if (a < b && a < c && b < c)
            {
                Console.Write(c);
                Console.Write(b);
                Console.Write(a);

            }



            else if (b < a && b < c && a < c)
            {

                Console.Write(c);
                Console.Write(a);
                Console.Write(b);

            }

            else if (a < b && a < c && c < b)
            {
                Console.Write(b);
                Console.Write(c);
                Console.Write(a);


            }


            else if (c < a && c < b && a < b)
            {

                Console.Write(b);
                Console.Write(a);
                Console.Write(c);

            }

            else if (c < a && b < a && c < b)
            {

                Console.Write(a);
                Console.Write(b);
                Console.Write(c);

            }



            else if (c < a && b < a && c < a)
            {

                Console.Write(a);
                Console.Write(c);
                Console.Write(b);

            }


            else
            {
                Console.WriteLine("Você digitou errado");
            }


        }
    }
}
