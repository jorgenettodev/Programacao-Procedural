using System;


/* 

crie um programa que receba um número inteiro que representa uma quantidade de moedas de um centavo.


“O total em dinheiro eh: x real(is) e y centavo(s)”


Exemplo de entrada:
1153

Saída esperada:
O total em dinheiro eh: 11 real(is) e 53 centavo(s)


*/

class Program
{
     static void Main(string[] args)
    {
        // input
        Console.WriteLine("Digite a quantidade em moedas que deseja converter para reais: ");

        int quantidadeMoedas = int.Parse(Console.ReadLine());
        int valorEmReais = quantidadeMoedas / 100;
        int valorEmCentavos = quantidadeMoedas % 100;

        // processamento
        string resultadoConversao = $"O total desta conversão é: {valorEmReais} real(is) e {valorEmCentavos} centavo(s).";

        // output
        Console.WriteLine(resultadoConversao);
    }
}