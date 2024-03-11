using System;

class Program
{
    static void Main(string[] args)
    {
        // crie um programa que diga a media de altura de jogadores de um time de basket e também a maior altura.
        double maiorAltura = 0;
        double mediaAltura = 0;
        double alturaAtual;
        double somatorioAltura = 0;
        const int QUANTIDADE_JOGADORES = 2;

        

        for (int i = 0; i < QUANTIDADE_JOGADORES; i++)
        {
            System.Console.WriteLine("Digite sua altura: ");
            alturaAtual = double.Parse(Console.ReadLine());
            somatorioAltura += alturaAtual;

            if (alturaAtual > maiorAltura)
            {
                maiorAltura = alturaAtual;
            }
        }
        mediaAltura = Math.Round((somatorioAltura / QUANTIDADE_JOGADORES), 2);
        maiorAltura = Math.Round(maiorAltura, 2);
        System.Console.WriteLine($"\nA media eh: {mediaAltura}ml");
        System.Console.WriteLine($"A maior altura eh: {maiorAltura}m");
    }
}