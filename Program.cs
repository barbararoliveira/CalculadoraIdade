using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime barbara = new DateTime (2004, 04, 06, 16, 13, 00);
            string barbara2 = barbara.ToShortDateString();
            DateTime dtagora = DateTime.Now;

            TimeSpan tempo =  dtagora - barbara;
            int dias = tempo.Days;
            
            Console.ForegroundColor = ConsoleColor.Magenta; 
            Console.WriteLine($"Eu nasci em {barbara2} e já vivi {dias} dias.");

        }
    }
}
