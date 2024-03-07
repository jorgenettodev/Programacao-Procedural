using System;

class Program
{
    static void Main(string[] args)
    {
        const int QUANTIDADE_MAXIMA_TENTATIVAS = 3;
        const string loginCorreto = "admin";
        const string senhaCorreta = "123senha";
        int i = 1;

        System.Console.WriteLine("Digite seu nome de usuario e senha.");
        do
        {
            System.Console.WriteLine("\nlogin: ");
            string loginUsuario = Console.ReadLine();

            System.Console.WriteLine("senha: ");
            string senhaUsuario = Console.ReadLine();

            if (loginUsuario == loginCorreto && senhaUsuario == senhaCorreta) // se acertar, sai do programa.
            {
                System.Console.WriteLine("\nLogin realizado com sucesso");
                break;
            } else if (i == QUANTIDADE_MAXIMA_TENTATIVAS) // se errar depois de 3 tentativas:
            {
                System.Console.WriteLine("\nSua conta foi bloqueada");
                break;
            } else // se errar, tente novamente e aumenta o contador
            {
                System.Console.WriteLine("\ntente novamente");
                i++;
            }
        }
        while (i <= QUANTIDADE_MAXIMA_TENTATIVAS);
    }
}