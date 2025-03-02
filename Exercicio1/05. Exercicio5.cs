using System;
using System.Threading;
using ConsoleApp;

/*

/----------------------------------------------------------/

EXERCICIO 5
Desenvolva um programa que peça ao usuário um valor em graus Celsius e o converta para Fahrenheit e Kelvin. 

Observações:

Utilize a fórmula: F = C * 9/5 + 32 e K = C + 273.15.
Exiba os resultados com duas casas decimais.
Considerações:

Cálculo correto das conversões.
Exibição formatada dos valores convertidos.

/----------------------------------------------------------/

*/

public class Exercicio5
{
    public void Executar()
    {
        Console.WriteLine("/--------------/ Exercício 5 /--------------/");

        Console.Write("Digite uma temperatura em graus Celsius: ");
        double entrada = Convert.ToDouble(Console.ReadLine());
        LimpaConsole.Limpar();

        var fahrenheit = ((entrada * 9) / 5) + 32;
        var kelvin = entrada + 273.15; 

        Console.WriteLine($"Temperatura em Celsius informada: {entrada} ºC");
        Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit} F");
        Console.WriteLine($"Temperatura em Kelvin: {kelvin} K\n");

        Contador.Contar();
        LimpaConsole.Limpar();
    }
}
