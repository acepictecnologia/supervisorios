using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 0;

            //Console.ForegroundColor = ConsoleColor.White;
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.SetWindowSize(50, 15);
            Console.Title = "Curso Supervisório - Visual C# (ACEPIC)!";

            Console.WriteLine("Digite um valor numérico: ");

            try
            {
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("O resultado de {0} / {1} é {2}.", x, y, x / y);
            }
            catch (Exception erro)
            {
                if (erro is FormatException)
                    Console.WriteLine("O valor digitado não é numérico!");

                if (erro is DivideByZeroException)
                    Console.WriteLine("Erro - Divisão por zero!");

            }
            finally
            {
                Console.WriteLine("Essa mensagem sempre deverá ser mostrada...");
            }

            Console.ReadLine();

        }
    }
}
