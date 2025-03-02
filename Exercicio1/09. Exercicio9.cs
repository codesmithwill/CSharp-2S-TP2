using System;
using System.Reflection.PortableExecutable;
using System.Threading;
using ConsoleApp;

/*

/----------------------------------------------------------/

EXERCICIO 9
Escreva um programa que solicite o salário bruto do usuário e calcule o valor líquido após descontos de impostos. 

Observações:

Utilize faixas de imposto definidas no código.
Exiba o salário bruto, os descontos e o salário líquido.
Considerações:

Uso correto de estruturas condicionais.
Cálculo correto dos descontos.
Exibição formatada das informações

/----------------------------------------------------------/

*/

public class Exercicio9
{
    public void Impostos()
    {
        Console.WriteLine("/---------------------/ TABELA DE IMPOSTOS /---------------------/");
        Console.WriteLine("/                                                                /");
        Console.WriteLine("/ Salários de até R$ 2.000,00                  =        5%       /");
        Console.WriteLine("/ Salários de R$ 2.001,00 até R$ 4.000,00      =        10%      /");
        Console.WriteLine("/ Salários de R$ 4.001,00 até R$ 6.000,00      =        15%      /");
        Console.WriteLine("/ Salários acima de R$ 6.000,00                =        20%      /");
        Console.WriteLine("/                                                                /");
        Console.WriteLine("/---------------------/--------------------/---------------------/\n");
    }
    public void Executar()
    {

        Console.WriteLine("/-------------------------/ Exercicio 9 /------------------------/");
        Impostos();

        double salario = 0; double imposto = 0; double liquido = 0; string porcentagem;

        while (salario <= 0)
        {
            Console.Write("\nDigite o seu salário bruto separando-o com vírgulas: R$ ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario <= 0)
            {
                LimpaConsole.Limpar();
                Console.Write("Salário inválido. Insira um valor positivo.");
            }
        }

        if (salario <= 2000)
        {
            imposto = salario * 0.05;
            porcentagem = "05%";
        }
        else if (salario <= 4000)
        {
            imposto = salario * 0.10;
            porcentagem = "10%";
        }
        else if (salario <= 6000)
        {
            imposto = salario * 0.15;
            porcentagem = "15%";
        }
        else
        {
            imposto = salario * 0.20;
            porcentagem = "20%";
        }

        liquido = salario - imposto;
        LimpaConsole.Limpar();

        Console.WriteLine("/-------------------------/ Informações /------------------------/");
        Console.WriteLine("/                                                                /");
        Console.WriteLine($"/ Seu salário:     R$ {salario:F2}                                    /");
        Console.WriteLine($"/ Imposto cobrado: R$  {imposto:F2}  ({porcentagem})                             /");
        Console.WriteLine($"/ Salário líquido: R$ {liquido:F2}                                    /");
        Console.WriteLine("/                                                                /");
        Console.WriteLine("/---------------------/--------------------/---------------------/\n");

        Contador.Contar();
        LimpaConsole.Limpar();
    }
}
