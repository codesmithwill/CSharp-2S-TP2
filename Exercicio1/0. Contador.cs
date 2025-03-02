using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Contador
    {
        public static void Contar()
        {
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"Voltando ao menu em... {i} segundos.");
                Thread.Sleep(1000);
            }
        }
    }
}
