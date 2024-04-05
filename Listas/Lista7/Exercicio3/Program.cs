using System;

class Program
{
    static void Main(string[] args)
    {
        int idade = int.Parse(Console.ReadLine());
        System.Console.WriteLine(RetornaCategoria(idade));
    }

    static string RetornaCategoria(int idade)
    {
        string categoria;

        if (idade < 12)
        {
            categoria = "Infantil";
        }
        else if (idade <= 14)
        {
            categoria = "Juvenil A";
        }
        else if (idade <= 17)
        {
            categoria = "Juvenil B";
        }
        else
        {
            categoria = "Adulto";
        }
        return categoria;
    }
}