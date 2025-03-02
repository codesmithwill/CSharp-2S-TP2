using System;
/*

/----------------------------------------------------------/

EXERCICIO 2
Desenvolva um programa que peça ao usuário sua data de nascimento e informe quantos dias faltam para o próximo aniversário. 

Observações:

Utilize a classe DateTime para calcular a diferença entre datas.
Exiba o resultado em dias.
Considerações:

Uso correto da classe DateTime.
Cálculo correto do intervalo de dias.
Exibição clara da saída.


/----------------------------------------------------------/

*/

public class Exercicio2
{
    public void Executar()
    {
        string sDia, sMes, sAno;
        int dia, mes, ano;
        Console.WriteLine("/--------------/ Exercício 2 /--------------/");

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
        DateTime hoje = DateTime.Now;
        DateTime proximoAniversario = new DateTime(hoje.Year, mes, dia);

        // Se o aniversário já passou este ano, calcula o próximo para o ano seguinte
        if (hoje > proximoAniversario)
        {
            proximoAniversario = proximoAniversario.AddYears(1);
        }

        TimeSpan diferenca = proximoAniversario - hoje;

        Console.WriteLine($"Faltam {diferenca.Days} dias para o seu próximo aniversário!");
    }
}
