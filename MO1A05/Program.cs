using System;

namespace MO1A05
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria uma variável do tipo var
            var n = -20;
            Console.WriteLine($"A variável num tem {n}");
            Console.WriteLine($"Num é do tipo {n.GetType()}");
            Console.ReadKey();
        }
    }
}
