using System;

class Program
{
    static void Main(string[] args)
    {
        const int QUANTIDADE_PESSOAS = 10;
        string[] vetorPessoas = new string[QUANTIDADE_PESSOAS];

        for (int indicePessoa = 0; indicePessoa < QUANTIDADE_PESSOAS; indicePessoa++)
        {
            vetorPessoas[indicePessoa] = Console.ReadLine();
        }

        for (int indicePessoa = QUANTIDADE_PESSOAS - 1; indicePessoa >= 0; indicePessoa--)
        {
            if (indicePessoa % 2 == 0)
            {
                Console.WriteLine(vetorPessoas[indicePessoa]);
            }
        }
    }
}