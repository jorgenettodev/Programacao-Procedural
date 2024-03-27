using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        // matriz 4x4
        const int TAMANHO_MATRIZ = 4;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                System.Console.WriteLine($"Digite a posição {linha}-{coluna}: ");
                int inputNumero = int.Parse(Console.ReadLine());
                matriz[linha, coluna] = inputNumero;
            }
        }

        System.Console.WriteLine("Digite uma opção de 1 a 5: ");
        int opcaoAcaoUsuario = int.Parse(Console.ReadLine());
        // opcao 1 Imprimir todos os elementos da matriz;

        if (opcaoAcaoUsuario == 1)
        {
            for (int i = 0; i < TAMANHO_MATRIZ; i++)
            {
                for (int j = 0; j < TAMANHO_MATRIZ; j++)
                {
                    System.Console.WriteLine(matriz[i, j]);
                }
            }
        }
        // 2 - Somar todos os elementos e exibir o resultado;
        else if (opcaoAcaoUsuario == 2)
        {
            int somatorioInteiros = 0;

            for (int i = 0; i < TAMANHO_MATRIZ; i++)
            {
                for (int j = 0; j < TAMANHO_MATRIZ; j++)
                {
                    somatorioInteiros += matriz[i, j];
                }
            }
            System.Console.WriteLine(somatorioInteiros);
        }
        else if (opcaoAcaoUsuario == 3)
        {
            int somatorioTerceiraLinha = 0;

            for (int i = 0; i < TAMANHO_MATRIZ; i++)
            {
                for (int j = 0; j < TAMANHO_MATRIZ; j++)
                {
                    if (i == 2)
                    {
                        somatorioTerceiraLinha += matriz[i, j];
                    }
                }
            }
            System.Console.WriteLine(somatorioTerceiraLinha);
        }
        else if (opcaoAcaoUsuario == 4)
        {
            int somatorioDiagonalPrincipal = 0;

            for (int i = 0; i < TAMANHO_MATRIZ; i++)
            {
                for (int j = 0; j < TAMANHO_MATRIZ; j++)
                {
                    if (i == j)
                    {
                        somatorioDiagonalPrincipal += matriz[i, j];
                    }
                }
            }
            System.Console.WriteLine(somatorioDiagonalPrincipal);
        }
        else if (opcaoAcaoUsuario == 5)
        {
            int somatorioLinha2IndicePar = 0;
            for (int i = 0; i < TAMANHO_MATRIZ; i++)
            {
                for (int j = 0; j < TAMANHO_MATRIZ; j++)
                {
                    if (i == 1 && j % 2 == 0)
                    {
                        somatorioLinha2IndicePar += matriz[i,j];
                    }
                }
            }
            System.Console.WriteLine(somatorioLinha2IndicePar);
        }
    }
}