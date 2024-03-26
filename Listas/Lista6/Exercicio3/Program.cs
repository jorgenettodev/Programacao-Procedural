using System;

class Program
{
    static void Main(string[] args)
    {
        // matriz
        const int TAMANHO_MATRIZ = 3;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];
        int somatorioDiagonalPrincipal = 0;

        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                matriz[linha, coluna] = int.Parse(Console.ReadLine());
                if (linha == coluna)
                {
                    somatorioDiagonalPrincipal += matriz[linha, coluna];
                }
            }
        }
        System.Console.WriteLine($"{somatorioDiagonalPrincipal}");
    }
}