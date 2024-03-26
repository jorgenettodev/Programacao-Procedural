using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        // vetor de tamanho 10;
        const int TAMANHO_VETOR = 10;
        const int MENOR_VALOR = 10;
        const int MAIOR_VALOR = 50;
        int[] vetorInteiros = new int[TAMANHO_VETOR];

        for (int indiceVetor = 0; indiceVetor < TAMANHO_VETOR; indiceVetor++)
        {
            int inputInteiro = int.Parse(Console.ReadLine());

            while (inputInteiro < MENOR_VALOR || inputInteiro > MAIOR_VALOR)
            {
                inputInteiro = int.Parse(Console.ReadLine());
            }

            vetorInteiros[indiceVetor] = inputInteiro;
        }

        for (int indiceVetor = 0; indiceVetor < TAMANHO_VETOR; indiceVetor++)
        {
            System.Console.WriteLine(vetorInteiros[indiceVetor]);
        }
    }
}