using System;

class Program
{
    static void Main(string[] args)
    {
        const string PALAVRA_CORRETA = "Cachorro";
        int contador = 1;
        const int MAXIMO_DE_TENTATIVAS = 3;

        System.Console.WriteLine("#### JOGO DE ADIVINHAR ####");
        int pontuacaoInicial = 100;
        double pontuacaoFinal;

        do
        {
            System.Console.WriteLine($"Esta é sua tentativa número {contador} de {MAXIMO_DE_TENTATIVAS}");
            System.Console.WriteLine("Digite uma palavra até acertar a palavra certa");
            string inPalavraDigitadaPeloUsuario = Console.ReadLine();

            if (inPalavraDigitadaPeloUsuario != PALAVRA_CORRETA)
            {
                System.Console.WriteLine($"\nIncorreto, você tem mais {MAXIMO_DE_TENTATIVAS - contador} tentativas");
                contador++;
            }
            else
            {
                System.Console.WriteLine($"\nVoce acertou! A palavra correta era {PALAVRA_CORRETA}!");
                pontuacaoFinal = pontuacaoInicial / contador;
                System.Console.WriteLine($"Sua pontuacao final foi: {pontuacaoFinal}");
                break;
            }
            
        }
        while (contador <= MAXIMO_DE_TENTATIVAS);

    }
}