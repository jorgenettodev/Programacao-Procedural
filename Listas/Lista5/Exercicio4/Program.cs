using System;

class Program
{
    static void Main(string[] args)
    {
        int somatorioNumerosImpares = 0;
        do
        {
            int inputNumero = int.Parse(Console.ReadLine());

            if (inputNumero < 0 ) // se numero for negativo, pare
            {
                break;
            }
            if (inputNumero % 2 != 0)
            {
                somatorioNumerosImpares += inputNumero;
            }

        }
        while (true);
        System.Console.WriteLine($"O somatorio de impares eh: {somatorioNumerosImpares}");
    }
}