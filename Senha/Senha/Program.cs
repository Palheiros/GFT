using System;

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int senha;

                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());

                if (senha == 2018)
                {
                    Console.WriteLine("Acesso garantido");
                    break;
                } else
                {
                    Console.WriteLine("Senha inválida");
                }
            }            
        }
    }
}
