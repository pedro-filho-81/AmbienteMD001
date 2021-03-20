using System;

namespace M01A06
{
    class Program
    {
        static void Main(string[] args)
        {
             float PI = 3.1415f;
            
            Console.WriteLine("REGRAS PARA CRIAR CONSTANTES!");
            
            String escola = "Estudonauta"; // cria uma variável
            
            const string CURSO = "CursoEmVideo"; // utilisar letras maiúsculas
            
            // imprime
            // mostra a função de pi
            Console.WriteLine($"O PI no programa é: {PI}");
            Console.WriteLine($"O tipo de PI no programa é: {PI.GetType()}");

            Console.WriteLine($"O valor de PI é {Math.PI}");            
            Console.WriteLine($"O tipo de PI no programa é {Math.PI.GetType()}");
            
            Console.WriteLine("Cria uma variável string:\n");
            Console.WriteLine("String escola = \"Estudonauta\"");
            Console.WriteLine($"Eu estou estudando no {escola}");
            
            Console.ReadKey();
        }
    }
}
