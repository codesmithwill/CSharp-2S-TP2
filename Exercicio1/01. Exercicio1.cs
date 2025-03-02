using System;
using System.Threading;
using ConsoleApp;

/*

/----------------------------------------------------------/

EXERCICIO 1
Crie um programa em C# que solicite a data de nascimento do usuário e calcule sua idade exata em anos, meses e dias. 

Observações:

Utilize a classe DateTime para capturar e manipular datas.
Considere anos bissextos no cálculo.
Exiba a idade formatada corretamente.
Considerações:

Uso correto da classe DateTime.
Cálculo preciso considerando anos e meses.
Formatação adequada da saída.

/----------------------------------------------------------/

*/

public class Exercicio1
{
    public void Executar()
    {
        string sDia, sMes, sAno;
        int dia, mes, ano;
        Console.WriteLine("/--------------/ Exercício 1 /--------------/");

        Console.Write("Digite o dia do seu nascimento (exemplo: 01 - 31): ");
        sDia = Console.ReadLine();

        Console.Write("Digite o mês do seu nascimento (exemplo: 01 - 12): ");
        sMes = Console.ReadLine();

        Console.Write("Digite o mês do seu nascimento (exemplo: 1900 - 2025): ");
        sAno = Console.ReadLine();

        dia = Convert.ToInt32(sDia);
        ano = Convert.ToInt32(sAno);
        mes = Convert.ToInt32(sMes);

        DateTime nascimento = new DateTime(ano, mes, dia);
        DateTime atual = DateTime.Now;

        int anos = atual.Year - nascimento.Year;

        if (atual.Month < nascimento.Month || (atual.Month == nascimento.Month && atual.Day < nascimento.Day))
        {
            anos--;
        }

        int meses = atual.Month - nascimento.Month;

        if (meses < 0)
        {
            meses += 12; // Ajuste se o mês atual for anterior ao mês de nascimento
        }

        if (atual.Day < nascimento.Day)
        {
            meses--;
        }

        int dias = (atual - nascimento.AddYears(anos).AddMonths(meses)).Days;
        Console.Clear();
        Console.WriteLine($"Você tem {anos} anos, {meses} meses e {dias} dias.\n");

        Contador.Contar();
        LimpaConsole.Limpar();
    }
}
