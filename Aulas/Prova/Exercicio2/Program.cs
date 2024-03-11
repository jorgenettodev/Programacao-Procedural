using System;
    // programa: sexo e idade. se idade >= 18 e sexo = m, DEVE REALIZAR ALISTAMENTO MILITAR, 
    // SENAO: não deve realizar alistamento militar.

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite seu sexo:");
        string inSexoUsuario = Console.ReadLine();

        System.Console.WriteLine("Digite sua idade:");
        int inIdadeUsuario = int.Parse(Console.ReadLine());

        if (inSexoUsuario == "masculino" && inIdadeUsuario >= 18)
        {
            System.Console.WriteLine("Deve realizar o alistamento militar.");
        } else
        {
            System.Console.WriteLine("Não deve realizar o alistamento militar.");
        }
    }
}