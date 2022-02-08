using System;

namespace LISTA_02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        { 

       
                float a, b, c;

                Console.Write("Digite o valor A: ");
                a = Convert.ToSingle(Console.ReadLine());

                Console.Write("Digite o valor B: ");
                b = Convert.ToSingle(Console.ReadLine());

                Console.Write("Digite o valor C: ");
                c = Convert.ToSingle(Console.ReadLine());


                if (a + b < c)

                    Console.WriteLine("A + B é menor que C!");

                else

                    Console.WriteLine("A + B não é menor que C!");

                Console.ReadLine();
            }
        }
    }

