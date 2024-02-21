using System;


/* 
Crie um programa na linguagem C# que calcule a média de um aluno de uma escola. Seu programa deve receber as 4 notas do aluno e extrair a média das 4 notas usando a seguinte fórmula:

media = (nota1 + nota2 + nota3 + nota4) / 4.0

Ao final, seu programa deve exibir a mensagem: 
“A media do aluno eh: x“ 

Exemplo de entrada:
6.2
7.3
3.5
3.7

Saída esperada:
A media do aluno eh: 5.175

*/

class Program
{
    static void Main(string[] args)
    {
        // input
        Console.WriteLine("Digite suas 4 notas que deseja saber a média.");

        Console.WriteLine("1a nota: ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("2a nota: ");
        double nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("3a nota: ");
        double nota3 = double.Parse(Console.ReadLine());
        Console.WriteLine("4a nota: ");
        double nota4 = double.Parse(Console.ReadLine());

        


        // processamento

        double media = (nota1 + nota2 + nota3 + nota4) / 4.0;
        // output
        Console.WriteLine($"A sua media eh:  {media}");
    }
}