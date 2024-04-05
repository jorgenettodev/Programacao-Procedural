using System;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        RecursivaRegressiva(n);
    }

    public static void RecursivaRegressiva(int x)
    {
        Console.WriteLine(x);
        if (x <= 1)
        {
            return;
        }
        x -= 3;
        RecursivaRegressiva(x);
    }
}