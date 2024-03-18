using System;

class Program
{
    static void Main(string[] args)
    {
        int alturaRetangulo = int.Parse(Console.ReadLine());
        int baseRetangulo = int.Parse(Console.ReadLine());

        for (int linhas = 0; linhas < alturaRetangulo; linhas++)
        {
            for (int colunas = 0; colunas < baseRetangulo; colunas++)
            {
                Console.Write("*"); // imprime um "*" por coluna;
            }
            System.Console.WriteLine(); // pula linha
        }
    }
}