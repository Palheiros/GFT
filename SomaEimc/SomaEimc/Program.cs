using System;

namespace SomaEimc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu de opções:" + "\n1. Soma"+ "\n2. IMC" + "\n3. Sair");
            Console.WriteLine("Digite a opção desejada:");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o primeiro número:");
                    double primeiroNum = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número:");
                    double segundoNum = double.Parse(Console.ReadLine());

                    double resultado = primeiroNum + segundoNum;
                    
                    Console.WriteLine($"A soma dos dois número é {resultado}.");
                    break;

                case 2:
                    Console.Write("Digite o seu peso: ");
                    double peso = double.Parse(Console.ReadLine());
                    Console.Write("Digite a sua altura: ");
                    double altura = double.Parse(Console.ReadLine());

                    resultado = peso / Math.Pow(altura, 2);

                    Console.WriteLine($"O seu IMC é {resultado}");
                    break;

                case 3:
                    break;

                default:
                    Console.WriteLine("Opção inválida. Digite 1, 2 ou 3.");
                    break;
            }

        }
    }
}
