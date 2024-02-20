using System;

class Program
{
    static void Main(string[] args)
    {
        // Recebe uma idade em dias, converte em anos. Se for maior de idade, lança true, caso contrário, false.
        Console.WriteLine("Digite sua idade em dias :");
        int idadeEmDias = int.Parse(Console.ReadLine());
        int idadeEmAnos = idadeEmDias / 365;
        bool ehMaiorDeIdade = idadeEmAnos >= 18;
        Console.WriteLine($"{idadeEmDias} equivale à {idadeEmAnos} anos, será que você é maior de idade? {ehMaiorDeIdade}");
    }
}