using System;

namespace M01A07
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Exp:. Conversão implícita int -> float
        int a = 8;
        float b = a;

        Console.WriteLine($"O valor de a é {a} do tipo {a.GetType()}");
        Console.WriteLine($"O valor de b é {b} do tipo {b.GetType()}");
        */

        /* Exp:. Conversão explícita float -> int
        float a = 8.2f;
        int b = (int) a;

        Console.WriteLine($"O valor de a é {a} do tipo {a.GetType()}");
        Console.WriteLine($"O valor de b é {b} do tipo {b.GetType()}");
        */
        
            // Exp:.Conversão explícita float -> int
            float a = 8.2f;
            int b = Convert.ToInt32(a);

            Console.WriteLine($"O valor de a é {a} do tipo {a.GetType()}");
            Console.WriteLine($"O valor de b é {b} do tipo {b.GetType()}");

            Console.ReadKey();
        }
    }
}
