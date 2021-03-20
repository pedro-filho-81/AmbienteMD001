using System;

namespace M01A05B
{
    class Program
    {
        static void Main(string[] args)
        {
            // CRIA VARIÁVEIS
            byte idade = 19;
            ushort publico = 45_123;
            float média = 4.5f; // C# ACEITA NOME DE VARIÁVEL COM ACENTO
            decimal estrela = 2.1234544321m;
            bool aprovado = false;
            int x;
            var y = 5.0;

            Console.WriteLine($"A variável idade tem o valor {idade}");
            Console.WriteLine($"idade é do tipo {idade.GetType()}");
            Console.ReadKey();
        }
    }
}
