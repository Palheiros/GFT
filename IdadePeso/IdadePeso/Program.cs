using System;

namespace IdadePeso
{
    public class Program
    {
        static void Main(string[] args)
        {
            int idade, somaIdade;
            double peso, somaPeso;
            int pessoas = 10;
       
            
            for (int i = 0; i < pessoas; i++)
            {
                Console.WriteLine("Digite a idade da pessoa {0}",i);
                idade = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite o peso da pessoa {0}", i);
                peso = double.Parse(Console.ReadLine());
            }
        }
    }
}
