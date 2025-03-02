using System;
using System.Reflection.PortableExecutable;
using System.Threading;
using ConsoleApp;

/*

/----------------------------------------------------------/

EXERCICIO 6
Escreva um programa que solicite peso e altura do usuário e calcule seu Índice de Massa Corporal (IMC), classificando-o em faixas de peso. 

Observações:

Utilize a fórmula: IMC = peso / (altura * altura).
Classifique o usuário conforme as faixas do IMC.
Considerações:

Cálculo correto do IMC.
Exibição da classificação correta.

/----------------------------------------------------------/

*/

public class Exercicio6
{
    public void Executar()
    {
        Console.WriteLine("/--------------/ Exercício 6 /--------------/");
        Console.Write("Digite o seu peso em kg (exemplo: 95): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a sua altura em metros (exemplo: 1,75): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double calculoIMC = peso / (altura * altura);

        LimpaConsole.Limpar();

        Console.WriteLine("ATENÇÃO! Caso seja exibido 0,0, refaça a entrada de valores corretamente.");
        Console.WriteLine($"O cálculo do seu IMC foi de {calculoIMC:F2}.");
        if (calculoIMC > 0 & calculoIMC <= 18.5)
        {
            Console.WriteLine($"Sua classificação é: Baixo Peso.\n");
        } 
        else if (calculoIMC > 18.5 && calculoIMC <= 24.9)
        {
            Console.WriteLine($"Sua classificação é: Peso Normal.\n");
        }
        else if (calculoIMC >= 25 && calculoIMC <= 29.9)
        {
            Console.WriteLine($"Sua classificação é: Excesso de Peso.\n");
        }
        else if (calculoIMC >= 30)
        {
            Console.WriteLine($"Sua classificação é: Obesidade.\n");
        }
        else if (calculoIMC >= 35)
        {
            Console.WriteLine($"Sua classificação é: Obesidade Extrema.\n");
        }

        Contador.Contar();
        LimpaConsole.Limpar();
    }
}
