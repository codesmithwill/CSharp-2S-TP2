using System;
using System.Reflection.PortableExecutable;
using System.Threading;
using ConsoleApp;

/*

/----------------------------------------------------------/

EXERCICIO 7
Crie um programa que solicite um número inteiro e determine se ele é par ou ímpar.

Observações:

Utilize estruturas condicionais para verificar a paridade.
Exiba uma mensagem indicando o resultado.
Considerações:

Uso correto de estruturas condicionais.
Cálculo correto da paridade.

/----------------------------------------------------------/

*/

public class Exercicio7
{
    public void Executar()
    {
        Console.WriteLine("/--------------/ Exercício 7 /--------------/");
        Console.Write("Digite um número inteiro: ");

        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nO Número digitado foi: {numero}.");

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par.\n");
        }
        else
        {
            Console.WriteLine("O número é ímpar\n");
        }

            Contador.Contar();
        LimpaConsole.Limpar();
    }
}
