using System;

class Program
/*
    Deve criar um programa q que cria um triangulo retângulo (o tamanho da altura eh igual ao tamanho da base)
    altura 3; base 3;
    1 a1b2
    12 a2b2
    123 a3b3
*/
{
    static void Main(string[] args)
    {
        // entrada do programa: pede um numero e salva numa variavel
        System.Console.WriteLine("Digite a altura do triangulo entre 1 e 9");
        int alturaFinal = int.Parse(Console.ReadLine());

        // ENQUANTO O USUARIO DIGITAR alturaFinal < 1 || alturaFinal > 9
        while (alturaFinal < 1 || alturaFinal > 9)
        {
            System.Console.WriteLine("altura invalida, insira uma altura entre 1 e 9");
            alturaFinal = int.Parse(Console.ReadLine());
        }

        const int VALOR_INCIAL = 1;


        for (int alturaDoTriangulo = VALOR_INCIAL; alturaDoTriangulo <= alturaFinal; alturaDoTriangulo++)
        {
            for (int baseDoTriangulo = VALOR_INCIAL; baseDoTriangulo <= alturaDoTriangulo; baseDoTriangulo++)
            {
                System.Console.Write($"{baseDoTriangulo}");
            }
            System.Console.WriteLine();
        }
    }
}