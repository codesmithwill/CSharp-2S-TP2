using System;
using System.Threading;
using ConsoleApp;

/*

/----------------------------------------------------------/

EXERCICIO 3
Escreva um programa que solicite ao usuário duas datas e calcule a diferença em dias, meses e anos entre elas. 

Observações:

Utilize a classe DateTime e TimeSpan para o cálculo.
Exiba o intervalo formatado corretamente.
Considerações:

Uso adequado das classes DateTime e TimeSpan.
Cálculo correto da diferença entre datas.
Exibição clara e bem formatada do resultado.

/----------------------------------------------------------/

*/

public class Exercicio3
{
    public void Executar()
    {
        Console.WriteLine("/--------------/ Exercício 3 /--------------/");

        Console.Write("1ª Data - Digite o dia (exemplo: 01 - 31): ");
        int dia1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("1ª Data - Digite o mês (exemplo: 01 - 12): ");
        int mes1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("1ª Data - Digite o ano (exemplo: 1900 - 2025): ");
        int ano1 = Convert.ToInt32(Console.ReadLine());
        DateTime data1 = new DateTime(ano1, mes1, dia1);

        LimpaConsole.Limpar();

        Console.Write("2ª Data - Digite o dia (exemplo: 01 - 31): ");
        int dia2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2ª Data - Digite o mês (exemplo: 01 - 12): ");
        int mes2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2ª Data - Digite o ano (exemplo: 1900 - 2025): ");
        int ano2 = Convert.ToInt32(Console.ReadLine());
        DateTime data2 = new DateTime(ano2, mes2, dia2);

        TimeSpan diferenca = data2 - data1;
        int dias = Math.Abs(diferenca.Days);
        int anos = Math.Abs(ano2 - ano1);
        int meses = Math.Abs((ano2 * 12 + mes2) -  (ano1 * 12 + mes1));

        LimpaConsole.Limpar();
        Console.WriteLine("Diferença entre as datas:");
        Console.WriteLine($"Dias: {dias}");
        Console.WriteLine($"Meses: {meses}");
        Console.WriteLine($"Anos: {anos}\n");

        Contador.Contar();
        LimpaConsole.Limpar();
    }
}
