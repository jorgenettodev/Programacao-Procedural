using System;

class Program
{
    static void Main(string[] args)
    {
        int inputNumero = int.Parse(Console.ReadLine());

        if (inputNumero > 0)
        {
            int somatorioNumerosImpares = 0;
            for (int i = 0; i <= inputNumero; i++)
            {
                if (i % 2 != 0)
                {
                somatorioNumerosImpares += i;
                }
            }
            Console.WriteLine(somatorioNumerosImpares);
        }
        else if (inputNumero < 0)
        {
            for (int i = 0; i >= inputNumero; i--)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        else
        {
            System.Console.WriteLine("nada a fazer aqui");
        }
    }
}