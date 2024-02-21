using System;

class Program
{
    static void Main(string[] args)
    {
        // inputs
        Console.WriteLine("Digite primeiro a base do triangulo e depois a altura do triangulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());
        double alturaTriangulo = double.Parse(Console.ReadLine());
        
        // processamento
        double area = (baseTriangulo * alturaTriangulo) / 2;
        bool areaTrianguloEhMaiorQue20 = area > 20;
        // output
        Console.WriteLine($"A area do triangulo eh maior que 20 ?  {areaTrianguloEhMaiorQue20}");
        Console.WriteLine($"A area do triangulo eh:  {area}"); // Coloquei para que saia também o valor da área, indenpendente se eh true ou false.
    }
}