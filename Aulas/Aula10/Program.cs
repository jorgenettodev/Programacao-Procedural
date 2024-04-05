/* 
Crie um programa que utilize laços de repetição para imprimir o seguinte padrão numérico:
9
98
987
9876
98765
987654
9876543
98765432
987654321
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();
        for (int linha = 0; linha <= 7; linha++)
        {
            for (int coluna = 0; coluna <= 7; coluna++)
            {
                if (coluna + linha > 7) 
                {
                    break;
                }
                Tabuleiro.Adicionar(linha, coluna, "C");
                // Console.Write(coluna);
            }
            // System.Console.WriteLine();
        }
        Tabuleiro.ImprimeTabuleiro();
    }
}