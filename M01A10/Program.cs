using System;

namespace M01A10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MOSTRA A DATA E A HORA ATUAL");

            // CRIA AS VARIÁVEIS
            int dia = DateTime.Now.Day; // para o dia de hoje
            int mes = DateTime.Now.Month; // para o mês atual
            int ano = DateTime.Now.Year; // para o ano atual
            // mostra a data de hoje
            Console.WriteLine($"Data: {dia}/{mes}/{ano}");

            // cria variáveis
            int horas = DateTime.Now.Hour; // para a hora atual
            int min = DateTime.Now.Minute; // para os minutos
            int sec = DateTime.Now.Second; // para os segundos
            // mosta hora, minutos e os segundos atuais
            Console.WriteLine($"Horas: {horas}:{min}:{sec}");

            Console.ReadKey(); // pausa o programa
        } // fim main
    } // fim classe
} // fim namespace
