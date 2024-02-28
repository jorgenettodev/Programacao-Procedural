using System;

class Program
{
    static void Main(string[] args)
    {
        // Programa que faz login, com os seguintes parâmetros: 
        // login: admin
        // senha: 123senha
        const string loginAdmin = "admin";
        const string senhaAdmin = "123senha";        

        Console.WriteLine("Digite seu login: ");
        string inputLogin = Console.ReadLine();
        Console.WriteLine("Digite sua senha: ");
        string inputSenha = Console.ReadLine();

        if(inputLogin == loginAdmin && senhaAdmin == inputSenha)
        {
            Console.WriteLine("Login realizado com sucesso!");
        } else
        {
            Console.WriteLine("Credenciais invalidas");
        }
        
    }
}