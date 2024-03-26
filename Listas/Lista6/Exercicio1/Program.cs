/* 
crie um programa que recebe 10 nomes, dps mais 1 nome. 
Este ultimo nome sera procurado na lista.
    Se for encontrado, output "ACHEI",
    SENAO, => "NÃO ACHEI"
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        const int QUANTIDADE_PESSOAS = 10;
        string[] listaPessoas = new string[QUANTIDADE_PESSOAS]; // 10 pessoas

        for (int indicePessoa = 0; indicePessoa < QUANTIDADE_PESSOAS; indicePessoa++)
        {
            listaPessoas[indicePessoa] = Console.ReadLine();
        }

        string pessoaBuscada = Console.ReadLine();
        bool achouPessoaBuscada = false;

        for (int indicePessoa = 0; indicePessoa < QUANTIDADE_PESSOAS; indicePessoa++)
        {
            if (listaPessoas[indicePessoa] == pessoaBuscada)
            {
                achouPessoaBuscada = true;
            }    
        }

        if (achouPessoaBuscada)
        {
            System.Console.WriteLine("ACHEI");
        }
        else
        {
            System.Console.WriteLine("NAO ACHEI");
        }
    }
}