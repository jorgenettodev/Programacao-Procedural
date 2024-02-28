using System;

class Program
{
    static void Main(string[] args)
    {
        // inputs
        Console.WriteLine("Digite suas 4 notas: ");
        double nota1 = double.Parse(Console.ReadLine());
        double nota2 = double.Parse(Console.ReadLine());
        double nota3 = double.Parse(Console.ReadLine());
        double nota4 = double.Parse(Console.ReadLine());

        // processamento
        double media = (nota1 + nota2 + nota3 + nota4) / 4.0;
        string resultado;
        if (media >= 5.0)
        {
            resultado = "Aluno aprovado";
        } else if (media <5.0 && media >= 3.0)
        {
            resultado = "Aluno em recuperacao";
        } else
        {
            resultado = "Aluno reprovado";
        }
        // output
        Console.WriteLine(resultado);
    }
}