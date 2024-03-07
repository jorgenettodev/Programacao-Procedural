using System;

/* 
- pedir quantidade de itens que o cliente comprou
- ler cada valor e soma-los
    - SE > 150, imprime “Parabens! Voce ganhou frete gratis em sua compra de valor x ”
    - SENAO imprime “A compra nao possui frete gratis"

*/

class Program
{
    static void Main(string[] args)
    {
        int i = 1; // obs coloquei como sendo 1 para contar a partir de 1 na hora de perguntar o valor do item.
        double somatorioItensComprados = 0;
        System.Console.WriteLine("Diga a quantidade de itens comprados: ");
        int QUANTIDADE_ITENS_COMPRADOS = int.Parse(Console.ReadLine());

        while(i <= QUANTIDADE_ITENS_COMPRADOS)
        {
            System.Console.WriteLine($"\nDigite o valor do item #{i}");
            somatorioItensComprados += double.Parse(Console.ReadLine());
            i++;
        }

        if (somatorioItensComprados >= 150) // no enunciado diz "acima de 150" entao estou na duvida se é maior que ou igual ou maior que 150.
        {
            System.Console.WriteLine($"\nParabens! Voce ganhou frete gratis em sua compra de valor R$ {somatorioItensComprados}");
        } else
        {
            System.Console.WriteLine("\nA compra nao possui frete gratis");
        }
    }
}