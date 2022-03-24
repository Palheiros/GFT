using System;
using System.Linq;

namespace Elefante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite um número inteiro: ");
            int repeticao = int.Parse(Console.ReadLine());
            string str = string.Concat(Enumerable.Repeat("Incomoda ", repeticao));

            Console.WriteLine($"{str}muito mais");
        }
    }
}
