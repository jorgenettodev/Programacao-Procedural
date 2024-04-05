using System;
public class Program
{
	public static void Main(string[] args)
	{
		int inputNumero = int.Parse(Console.ReadLine());
		Console.Write(EhPar(inputNumero));
	}

	static bool EhPar(int numero)
	{
		return numero % 2 == 0;
	}
}