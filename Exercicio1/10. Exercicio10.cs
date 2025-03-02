using System;
using System.Reflection.PortableExecutable;
using System.Threading;
using ConsoleApp;

/*

/----------------------------------------------------------/

EXERCICIO 10
Crie um programa que solicite um número ao usuário e exiba uma contagem regressiva até 0. 

Observações:

Utilize um laço de repetição para realizar a contagem.
Exiba os números separados por vírgula.
Considerações:

Uso correto do laço de repetição.
Exibição correta da contagem.

/----------------------------------------------------------/

*/

public class Exercicio10
{
    public void Executar()
    {

        Console.WriteLine("/-------------------------/ Exercicio 10 /------------------------/");
        Console.Write("Digite um número para ser realizada uma contagem: ");

        for (int i = Convert.ToInt32(Console.ReadLine()); i >= 0; i--)
        {
            Console.Write(i + ", ");
            if (i == 0)
            {
                Console.WriteLine("\nContagem encerrada.\n");
            }
        }

        Contador.Contar();
        LimpaConsole.Limpar();
    }
}
