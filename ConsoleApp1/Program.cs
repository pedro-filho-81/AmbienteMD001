using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // CRIANDO o objeto da classe Randon()
            Random gerador = new Random();

            // cria variável para o objeto gerador
            int num = gerador.Next(1, 7); 

            // mostra resultado
            Console.WriteLine($"Número aleatório: {num}");
            Console.ReadKey();
        }
    }
}
