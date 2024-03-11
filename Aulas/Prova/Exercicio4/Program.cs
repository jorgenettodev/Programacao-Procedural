// capturas as idades de 10 alunos da turma de programacao e calcule a idade media da turma
using System;

class Program
{
    static void Main(string[] args)
    {
        int somatorioIdades = 0;
        const int QUANTIDADE_ALUNOS = 10;

        for (int i = 0; i < QUANTIDADE_ALUNOS; i++)
        {
            System.Console.WriteLine("Digite sua idade");
            int idadeAlunoAtual = int.Parse(Console.ReadLine());
            somatorioIdades += idadeAlunoAtual;
        }
        int mediaIdades = somatorioIdades / QUANTIDADE_ALUNOS;
        System.Console.WriteLine($"\nA media de idades eh: {mediaIdades}");
    }
}