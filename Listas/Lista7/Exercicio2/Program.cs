using System;

class Program
{
    static void Main(string[] args)
    {
        int inputNumeroA = int.Parse(Console.ReadLine());
        int inputNumeroB = int.Parse(Console.ReadLine());
        int inputNumeroC = int.Parse(Console.ReadLine());
        System.Console.WriteLine(RetornaMaiorNumero(inputNumeroA, inputNumeroB, inputNumeroC));
    }

    static int RetornaMaiorNumero(int a, int b, int c)
    {
        int maiorNumero = int.MinValue;

        if (a > b && a > c)
        {
            maiorNumero = a;
        }
        else if (b > a && b > c)
        {
            maiorNumero = b;
        }
        else
        {
            maiorNumero = c;
        }
        return maiorNumero;
    }
}

