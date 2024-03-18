using System;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();
        for (int contadorExterno = 0; contadorExterno <= 7; contadorExterno++) 
        // obs: coloquei os nomes contadorExterno e contadorInterno para fixar este conteúdo e entender melhor o funcionamento de laços aninhados.
        {
            for(int contadorInterno = 0; contadorInterno <= 7; contadorInterno++)
            {
                if (contadorExterno % 2 != 0)
                {
                    continue; // se a linha for impar, pule linha;
                }
                Tabuleiro.Adicionar(contadorExterno, contadorInterno, "C");
            }

        }
        Tabuleiro.ImprimeTabuleiro();
    }
}