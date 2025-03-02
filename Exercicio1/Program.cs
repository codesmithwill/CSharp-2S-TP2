using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != -1)
            {
                Console.WriteLine("/-------------------- TP2 - Exercicios C# --------------------/");
                Console.WriteLine("1 - Exercício 01");
                Console.WriteLine("2 - Exercício 02");
                Console.WriteLine("3 - Exercício 03");
                Console.WriteLine("4 - Exercício 04");
                Console.WriteLine("5 - Exercício 05");
                Console.WriteLine("6 - Exercício 06");
                Console.WriteLine("7 - Exercício 07");
                Console.WriteLine("8 - Exercício 08");
                Console.WriteLine("9 - Exercício 09");
                Console.WriteLine("10 - Exercício 10");
                Console.WriteLine("11 - Exercício 11");
                Console.WriteLine("12 - Exercício 12");
                Console.WriteLine("\n-1 - Para encerrar a aplicação.");
                Console.WriteLine("/--------------------/-------------------/--------------------/\n");
                Console.Write("Digite: ");

                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Exercicio1 ex1 = new Exercicio1();
                            LimpaConsole.Limpar();
                            ex1.Executar();
                            break;
                        case 2:
                            Exercicio2 ex2 = new Exercicio2();
                            LimpaConsole.Limpar();
                            ex2.Executar();
                            break;
                        case 3:
                            Exercicio3 ex3 = new Exercicio3();
                            LimpaConsole.Limpar();
                            ex3.Executar();
                            break;
                        case 4:
                            Exercicio4 ex4 = new Exercicio4();
                            LimpaConsole.Limpar();  
                            ex4.Executar();
                            break;
                        case 5:
                            Exercicio5 ex5 = new Exercicio5();
                            LimpaConsole.Limpar();
                            ex5.Executar();
                            break;
                        case 6:
                            Exercicio6 ex6 = new Exercicio6();
                            LimpaConsole.Limpar();
                            ex6.Executar();
                            break;
                        case 7:
                            Exercicio7 ex7 = new Exercicio7();
                            LimpaConsole.Limpar();
                            ex7.Executar();
                            break;
                        case 8:
                            Exercicio8 ex8 = new Exercicio8();
                            LimpaConsole.Limpar();
                            ex8.Executar();
                            break;
                        case 9:
                            Exercicio9 ex9 = new Exercicio9();
                            LimpaConsole.Limpar();
                            ex9.Executar();
                            break;
                        case 10:
                            Exercicio10 ex10 = new Exercicio10();
                            LimpaConsole.Limpar();
                            ex10.Executar();
                            break;
                        case 11:
                            Exercicio11 ex11 = new Exercicio11();
                            LimpaConsole.Limpar();
                            ex11.Executar();
                            break;
                        case 12:
                            Exercicio12 ex12 = new Exercicio12();
                            LimpaConsole.Limpar();
                            ex12.Executar();
                            break;
                        case -1:
                            LimpaConsole.Limpar();
                            Console.WriteLine("Saindo da aplicação.");
                            break;
                        default:
                            LimpaConsole.Limpar();
                            Console.WriteLine("Opção inválida.\n");
                            break;
                    }
                }
                else
                {
                    LimpaConsole.Limpar();
                    Console.WriteLine("ERRO: Digite um número.\n");
                    opcao = 0;
                }
            }
        }
    }
}