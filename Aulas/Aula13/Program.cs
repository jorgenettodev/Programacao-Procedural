using System;
public class Program
{
    static void VisitarPaisDoFogo()
    {
        int pontoDeExploracao = int.Parse(Console.ReadLine());
        if (pontoDeExploracao == 1)
        {
            Console.WriteLine("Voce adentrou:Aldeia da folha");
        }
        else if (pontoDeExploracao == 2)
        {
            Console.WriteLine("Voce adentrou:Floresta da morte");
        }
    }

    static void VisitarPaisDoVento()
    {
        int pontoDeExploracao = int.Parse(Console.ReadLine());

        if (pontoDeExploracao == 1)
        {
            Console.WriteLine("Voce adentrou:Aldeia da areia");
        }
        else if (pontoDeExploracao == 2)
        {
            Console.WriteLine("Voce adentrou:Mina");
        }
        else if (pontoDeExploracao == 3)
        {
            Console.WriteLine("Voce adentrou:Floresta da morte");
        }
    }


    static void ViajarEntreMapas()
    {
        string paisEscolhido = Console.ReadLine();
        if (paisEscolhido == "1")
        {
            VisitarPaisDoFogo();
        }
        else if (paisEscolhido == "2")
        {
            VisitarPaisDoFogo();
        }
    }

    static void Main(string[] args)
    {
        ViajarEntreMapas();
    }
}