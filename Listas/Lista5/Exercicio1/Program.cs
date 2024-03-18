using System;

class Program
{
    static void Main(string[] args)
    {
        int regressivo = 200;
        for (int progressivo = 0; progressivo <= 100; progressivo +=2 )
        {
            System.Console.WriteLine($"{progressivo} - {regressivo}");
            regressivo -= 4;
        }
    }
}