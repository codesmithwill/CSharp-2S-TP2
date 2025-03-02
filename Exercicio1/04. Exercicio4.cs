using System;
using System.Threading;
using ConsoleApp;

/*

/----------------------------------------------------------/

EXERCICIO 4
Crie um programa que solicite nome, idade, telefone e e-mail do usuário e exiba os dados cadastrados de forma organizada. 

Observações:

Utilize Console.ReadLine() para entrada de dados.
Exiba os dados de forma formatada e clara.
Considerações:

Uso correto de Console.ReadLine().
Exibição organizada e formatada das informações.o.

/----------------------------------------------------------/

*/

public class Exercicio4
{
    public void Executar()
    {
        Console.WriteLine("/--------------/ Exercício 4 /--------------/");
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite seu telefone: ");
        string telefone = Console.ReadLine();

        Console.Write("Digite seu e-mail: ");
        string email = Console.ReadLine();

        LimpaConsole.Limpar();

        Console.WriteLine("/--------------/ Informações /--------------/");
        Console.WriteLine($"/ Seu nome: {nome}.");
        Console.WriteLine($"/ Sua idade: {idade}.");
        Console.WriteLine($"/ Seu telefone: {telefone}.");
        Console.WriteLine($"/ Seu e-mail: {email}.");
        Console.WriteLine("/--------------/-------------/--------------/\n");

        Contador.Contar();
        LimpaConsole.Limpar();
    }
}
