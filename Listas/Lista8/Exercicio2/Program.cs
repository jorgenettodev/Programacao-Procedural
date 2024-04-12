using System;

struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;
}

class Program
{
    static void Main(string[] args)
    {
        Produto[] produtos = new Produto[4];  // cria uma variável "produtos" do tipo Produto, que recebe um array de tamanho 4;

        // cria vitrine
        for (int i = 0; i < produtos.Length; i++)
        {
            produtos[i].id = Convert.ToInt32(Console.ReadLine());
            produtos[i].nome = Console.ReadLine();
            produtos[i].preco = Convert.ToDouble(Console.ReadLine());
            produtos[i].disponivelEmEstoque = Convert.ToBoolean(Console.ReadLine());
        }

        // mostra vitrine com produtos disponíveis
        for (int i = 0; i < produtos.Length; i++)
        {
            if (produtos[i].disponivelEmEstoque)
            {
                System.Console.WriteLine(produtos[i].nome);
                System.Console.WriteLine($"{produtos[i].preco:F2}");
            }
        }
    }
}