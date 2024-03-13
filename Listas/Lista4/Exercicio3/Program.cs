using System;

class Program
{
    static void Main(string[] args)
    {
        // faça um programa que preencha as lateriais do tabuleiro com a letra "s";
        Tabuleiro.InicializaTabuleiro();

        int inicio = 0;
        int final = 7;

        for (int linha = inicio; linha <= final; linha++)
        {
            for (int coluna = inicio; coluna <= final; coluna++)
            {
                // Se for a linha inicial ou final, imprime
                if (linha == inicio || linha == final)
                {
                    Tabuleiro.Adicionar(linha, coluna, "s");
                }

                // Se for a coluna inicial ou final, imprime
                if (coluna == inicio || coluna == final)
                {
                    Tabuleiro.Adicionar(linha, coluna, "s");
                }
            }
        }
        
        // imprime o tabuleiro final
        Tabuleiro.ImprimeTabuleiro();
    }
}