using System;

        /* 
        Você deve criar um programa que peça para cada usuário digitar as informações acima, armazene-as em variáveis e, ao final, calcule e imprima na tela seus respectivos valores. 
        A prefeitura de uma cidade pretende realizar uma pesquisa entre 20 de seus habitantes, coletando dados sobre o salário e número de filhos. A prefeitura deseja saber:  
        a) média do salário da população;
        b) média do número de filhos por habitante;
        c) maior salário;
        */
class Program
{
    static void Main(string[] args)
    {
        double somatorioSalario = 0;
        double somatorioFilhosPopulacao = 0;
        double maiorSalario = 0;
        const int QUANTIDADE_USUARIOS = 20;

        for (int i = 0; i < QUANTIDADE_USUARIOS; i++)
        {
            System.Console.WriteLine("\nDigite o seu salario: ");
            double salarioUsuario = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a quantidade de filhos: ");
            double numeroFilhosUsuario = double.Parse(Console.ReadLine());

            somatorioSalario += salarioUsuario;
            somatorioFilhosPopulacao += numeroFilhosUsuario;

            if (salarioUsuario > maiorSalario)
            {
                maiorSalario = salarioUsuario;
            }
        }
        double mediaSalario = Math.Round(somatorioSalario / QUANTIDADE_USUARIOS, 2);
        double mediaFilhosPopulacao = Math.Round(somatorioFilhosPopulacao / QUANTIDADE_USUARIOS, 2);

        System.Console.WriteLine($"\nMedia de salario da populacao = R$ {mediaSalario}");
        System.Console.WriteLine($"Media de filhos por habitante = {mediaFilhosPopulacao}");
        System.Console.WriteLine($"Maior salario computado = R$ {Math.Round(maiorSalario, 2)}");
    }
}