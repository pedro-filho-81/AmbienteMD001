using System;

namespace M01A08E
{
    class Program
    {
        static void Main(string[] args)
        {
            // CRIA VARIÁVEL
            int num1 = 0;
            
            // entrada de dados
            Console.WriteLine("Digite um número: ");
            
            // entrada do usuário
            int.TryParse(Console.ReadLine(), out num1);
            
            // var num2 recebe o dobro de dois
            int num2 = num1 * 2;
            
            // mostra o resultado 
            Console.WriteLine($"O valor digitado é {num1}\nO dobro é {num2}");
        }
    }
}
