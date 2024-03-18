using System;

class Program
{
    static void Main(string[] args)
    {
        for (int multiplicando = 10; multiplicando >= 1; multiplicando--)
        {
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                int produto = multiplicando * multiplicador;
                System.Console.WriteLine($"{multiplicando} * {multiplicador} = {produto}");
            }
            System.Console.WriteLine();
        }
    }
}