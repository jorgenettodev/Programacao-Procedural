using System;

        // crie um programa que cria várias tabuadas, do 1 até o 10, uma abaixo da outra
        /*
        multiplicando * multiplicador = propduto
        1x1=1
        1x2=2
            --> pulo de linha
        2x1=2
        2x2=4
        
        */
class Program
{
    static void Main(string[] args)
    {
        const int VALOR_INICIAL = 1;
        const int VALOR_FINAL = 10;
        int produto;

        for (int multiplicando = VALOR_INICIAL; multiplicando <= VALOR_FINAL; multiplicando++)
        {
            for (int multiplicador = VALOR_INICIAL; multiplicador <= VALOR_FINAL; multiplicador++)
            {
                produto = multiplicando * multiplicador;
                System.Console.WriteLine($"{multiplicando} x {multiplicador} = {produto}");
            }
            System.Console.WriteLine();
        }
    }
}