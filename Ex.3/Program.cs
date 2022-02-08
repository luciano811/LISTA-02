/* 
 
  Exercício 3:
• O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta.

• A fórmula é IMC = peso / (altura) ²

• Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a tabela abaixo.

IMC em adultos Condição
Abaixo de 18,5
Abaixo do peso
Entre 18,5 e 25 Peso normal
Entre 25 e 30
Acima do peso
Acima de 30 obeso

*/




using System;

namespace Ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura;


            Console.WriteLine("Bem-vindo as calculadora de IMC");
            

            Console.WriteLine("Digite o seu peso: ");
            peso= Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            altura = Convert.ToSingle(Console.ReadLine());

            float altura2 = altura * altura;

            float IMC = peso / altura2;

            Console.WriteLine("Seu IMC é: ");

            Console.WriteLine(IMC);

            if (IMC < 18.5)

                Console.WriteLine("Você está abaixo do peso");

            else if (IMC > 18.5 && IMC < 25)
                Console.WriteLine("Seu peso é normal");

            else if (IMC > 25)
                Console.WriteLine("Você está acima do peso");

            Console.ReadKey();
        }
    }
}
