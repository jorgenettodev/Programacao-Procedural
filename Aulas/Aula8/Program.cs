using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        const int tamanhoQuadrado = 8;

        for (int linha = 0; linha < tamanhoQuadrado; linha++)
        {
            for (int coluna = 0; coluna < tamanhoQuadrado; coluna++)
            {
                if (linha + coluna == tamanhoQuadrado - 1)
                {
                    Console.Write("x");
                }
                else {
                    Console.Write("-");
                }
            }
            System.Console.WriteLine();
        }
    }
}