using System;

namespace M01A04
{
    class Program
    {
        static void Main(string[] args)
        {
            // TIPOS PRIMITIVOS ( variáveis do tipo byte )
            Console.WriteLine("LISTA DOS TIPOS PRIMITIVOS INTEIROS DO C# "); // 
            Console.WriteLine($"O tipo byte vai de {byte.MinValue} até {byte.MaxValue} "); // inteiro de 8 bit sem sinal
            Console.WriteLine($"O tipo sbyte vai de {sbyte.MinValue} até {sbyte.MaxValue}"); // inteiro de 8 bits com sinal
            Console.WriteLine($"O tipo short vai de {short.MinValue} até {short.MaxValue}"); // inteiro de 16 bits sem sinal
            Console.WriteLine($"O tipo ushort vai de {ushort.MinValue} até {ushort.MaxValue}"); // inteiro de 16 bits com sinal
            Console.WriteLine($"O tipo int vai de {int.MinValue} até {int.MaxValue}"); // inteiro assinado com 32 bits
            Console.WriteLine($"O tipo uint vai de {uint.MinValue} até {uint.MaxValue}"); // inteiro com 32 bits sem sinal
            Console.WriteLine($"O tipo long vai de {long.MinValue} até {long.MaxValue}"); // inteiro  assinado com 64 bits
            Console.WriteLine($"O tipo ulong vai de {ulong.MinValue} até {ulong.MaxValue}"); // inteiro com 64 bits sem sinal

            // TIPOS PRIMITIVOS DE PONTO FLUTUANTE
            Console.WriteLine("\nLISTA DOS TIPOS PRIMITIVOS de ponto flutuante DO C# ");
            Console.WriteLine($"O tipo float vai de {float.MinValue} até {float.MaxValue}");
            Console.WriteLine($"O tipo double vai de {double.MinValue} até {double.MaxValue}");
            Console.WriteLine($"o tipo decimal vai de {decimal.MinValue} até {decimal.MaxValue}");

            Console.WriteLine("\nLISTA DOS TIPOS PRIMITIVOS boleano DO C# ");
            Console.WriteLine($"O tipo bool ou é {bool.FalseString} ou {bool.TrueString}");
            Console.ReadKey(); 
        }
    }
}
