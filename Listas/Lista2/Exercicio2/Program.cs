using System;
using System.Runtime.InteropServices;

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
        const double aprovado = 5.0;
        const double recuperacao = 3.0;


        if (media >= aprovado)
        {
            resultado = "Aluno aprovado";
        } else if (media >= recuperacao)
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