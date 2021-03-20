using System;

namespace M01A02E
{
    class Program
    {
        static void Main(string[] args)
        {
            /* move o cursor para a posição
               coluna 20, linha 10*/
            Console.SetCursorPosition(20, 10);
            // com as letras vermelha
            Console.ForegroundColor = ConsoleColor.Red;
            // fundo branco
            Console.BackgroundColor = ConsoleColor.White;
            // imprime
            Console.WriteLine("Hello World!");
            Console.ReadKey(); // pausa o programa
            // volta às cores normais
            Console.ResetColor(); // 
            Console.Clear(); // limpa a tela
            
            /* move o cursor para a posição
               coluna 30, linha 5*/
            Console.SetCursorPosition(30, 5);
            // MUDA A COR DAS LETRAS
            Console.ForegroundColor = ConsoleColor.White; // branco
            // muda a cor do fundo
            Console.BackgroundColor = ConsoleColor.Blue; // azul
            // imprime
            Console.WriteLine("Olá, querido(a) Estudonauta!");
            Console.ReadKey(); // pausa
            // valta às cores normais
            Console.ResetColor();
            Console.Clear(); // limpa a tela

            /* move o cursor para a posição
               coluna 10, linha 15*/
            Console.SetCursorPosition(10, 15);
            // muda a cor das letras
            Console.ForegroundColor = ConsoleColor.Green; // verde
            // muda a cor do fundo para amarelo
            Console.BackgroundColor = ConsoleColor.Yellow; // amarelo
            // imprime
            Console.WriteLine("Oi,\ntudo\nbem\ncom\nvocê?");
            Console.ReadKey(); // pausa
            // volta para às cores normais
            Console.ResetColor();
            Console.Clear(); // limpa a tela
            
        } // fim main
    } // fim classe
} // fim namespace

