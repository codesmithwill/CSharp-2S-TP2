using System;
using System.Reflection.PortableExecutable;
using System.Threading;
using ConsoleApp;
using static System.Runtime.InteropServices.JavaScript.JSType;

/*

/----------------------------------------------------------/

EXERCICIO 11
Desenvolva um programa que solicite um número ao usuário e exiba sua tabuada de 1 a 10. 

Observações:

Utilize um laço de repetição para calcular a tabuada.
Considerações:

Uso adequado do laço de repetição.
Cálculo correto da tabuada.

/----------------------------------------------------------/

*/

public class Exercicio11
{
    public void Executar()
    {

        Console.WriteLine("/-------------------------/ Exercicio 11 /------------------------/");

        Console.Write("Insira o número que deseja ver a tabuada: ");

        int tabuada;

        while (!int.TryParse(Console.ReadLine(), out tabuada) || tabuada <= 0)
        {
            Console.WriteLine("Número inválido. Digite um número inteiro.");
            Console.Write("Insira o número que deseja ver a tabuada: ");
        }

        LimpaConsole.Limpar();

        Console.WriteLine($"/-------------------------/ Tabuada do {tabuada} /------------------------/");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"/ {tabuada} x {i} = {tabuada * i}");
            if (i == 10)
            {
                Console.WriteLine("\nTabuada encerrada!\n");
            }
        }

        Contador.Contar();
        LimpaConsole.Limpar();
    }
}
