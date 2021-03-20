using System;

namespace M01A08
{
    class Program
    {
        static void Main(string[] args)
        {
            // CRIA VARIÁVEL
            string nome;
            // entrada de dados
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            // IMPRIME MENSAGEM
            Console.WriteLine($"Muito prazer em te conhecer, {nome}!\n");

            Console.ReadKey();

        }
    }
}
