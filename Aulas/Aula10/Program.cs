/* 
Crie um programa que utilize laços de repetição para imprimir o seguinte padrão numérico:
9
98
987
9876
98765
987654
9876543
98765432
987654321
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        for (int outer = 9; outer >= 1; outer--)
        {
            for (int inner = 9; inner >= outer; inner--)
            {
                System.Console.Write(inner);
            }
            System.Console.WriteLine();
        }

    }
}