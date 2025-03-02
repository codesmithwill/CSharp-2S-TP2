using System;
using System.Reflection.PortableExecutable;
using System.Threading;
using ConsoleApp;

/*

/----------------------------------------------------------/

EXERCICIO 12
Escreva um programa que gere um número aleatório de 1 a 100 e permita que o usuário tente adivinhá-lo, informando se o palpite é maior ou menor até acertar. 

Observações:

Utilize um laço de repetição para permitir múltiplos palpites.
Utilize a classe Random para gerar o número secreto.
Considerações:

Uso correto do laço de repetição.
Implementação correta da lógica de adivinhação.
Exibição de mensagens de feedback adequadas.

/----------------------------------------------------------/

*/

public class Exercicio12
{
    public void Executar()
    {
        Random aleatorio = new Random();
        int min = 1; int max = 100; int tentativas = 0;
        int palpite;


        int numeroAleatorio = aleatorio.Next(min, max);

        Console.WriteLine("Bem vindo(a), ao Jogo da Advinhação!");
        Console.WriteLine("Você terá que adivinhar o número que foi gerado pelo computador.");
        Console.WriteLine("Espero que você se divirta!\n");
        Console.WriteLine($"Número mínimo gerado: {min}");
        Console.WriteLine($"Número máximo gerado: {max}");
        Console.WriteLine($"Suas tentativas: {tentativas}\n");

        do
        {
            Console.Write("Dê o seu palpite: ");
            palpite = int.Parse(Console.ReadLine());
            tentativas++;

            if (palpite == numeroAleatorio)
            {
                LimpaConsole.Limpar();
                Console.WriteLine($"Parabéns! O número gerado era {numeroAleatorio}\nTentativas: {tentativas}\n");
            }
            else if (palpite > numeroAleatorio)
            {
                Console.WriteLine("O número digitado é maior que o número gerado.\n");
            }
            else if (palpite < numeroAleatorio)
            {
                Console.WriteLine("O numero digitado é menor que o número gerado.\n");
            }
        }
        while (palpite != numeroAleatorio);

        Contador.Contar();
        LimpaConsole.Limpar();
    }
}
