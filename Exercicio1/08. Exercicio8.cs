using System;
using System.Reflection.PortableExecutable;
using System.Threading;
using ConsoleApp;

/*

/----------------------------------------------------------/

EXERCICIO 8
Desenvolva um programa que peça ao usuário uma nota de 0 a 10 e classifique-a como "Insuficiente", "Regular", "Bom" ou "Excelente". 

Observações:

Utilize estruturas condicionais para determinar a classificação.
Considerações:

Uso adequado das estruturas condicionais.
Classificação correta conforme a nota informada.

/----------------------------------------------------------/

*/

public class Exercicio8
{
    public void Executar()
    {
        Console.WriteLine("/--------------/ Exercício 8 /--------------/");
        Console.Write("Digite uma nota: ");
        double nota = Convert.ToInt32(Console.ReadLine());

        if (nota < 3) 
        {
            Console.WriteLine("Nota Insuficiente.");
        }
        else if (nota >= 4 && nota <= 6)
        {
            Console.WriteLine("Nota Regular.\n");
        }
        else if (nota >= 7 && nota <= 8)
        {
            Console.WriteLine("Nota Boa.\n");
        }
        else if (nota > 9)
        {
            Console.WriteLine("Nota Excelente.\n");
        } else
        {
            Console.WriteLine("ERRO: Confira se a nota foi digitada corretamente.\n");
        }

        Contador.Contar();
        LimpaConsole.Limpar();
    }
}
