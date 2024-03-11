using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite seu peso: ");
        double peso = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite sua altura: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = Math.Round(peso / (altura * altura));

        System.Console.WriteLine($"{imc}");

        
    }
}