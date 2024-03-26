using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 3;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                int inputNumero = int.Parse(Console.ReadLine());

                if (linha + coluna == TAMANHO_MATRIZ - 1)
                {
                    matriz[linha, coluna] = inputNumero * 2;
                    continue;
                }
                
                matriz[linha, coluna] = inputNumero;
            }
        }

        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                Console.Write($"{matriz[linha, coluna]}|");
            }
            System.Console.WriteLine();
        }
    }
}